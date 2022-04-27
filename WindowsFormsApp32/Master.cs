using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp32.Database;
using WindowsFormsApp32.Entity;

namespace WindowsFormsApp32
{
    public partial class Master : Form
    {

        private readonly DatabaseContext _context;
        FlowLayoutPanel flpMainControl;
        public Master()
        {
            InitializeComponent();
            _context = new DatabaseContext();
        }

        private void Master_Load(object sender, EventArgs e)
        {
            CreateControls(tpFruits, 1);
            CreateControls(tpVegetable, 2);
            CreateControls(tpMilk, 3);
            CreateControls(tpMeat, 4);
            CreateControls(tpSoup, 5);
            CreateControls(tpBreakfast, 6);
            CreateControls(tpCerealsProduct, 7);
            CreateControls(tpMainCourse, 8);
            CreateControls(tpSnack, 9);
            CreateControls(tpDrinks, 10);
            GetMealType();
            dtSelectDateWeakly2.Value = dtSelectDateWeakly1.Value.AddDays(7);
            

        }


        public void OpenProfile(string userName) //Giriş yapan kullanıcının Profil sayfasını oluşturur.
        {
            var result = from ud in _context.UserDetails
                         join u in _context.Users
                         on ud.UserID equals u.UserID
                         where u.UserName == userName
                         select new
                         {

                             ud.FirstName,
                             ud.LastName,
                             ud.Height,
                             ud.Weight,
                             ud.Age,
                             ud.Gender,
                             u.UserName,
                             u.Password
                         };
            foreach (var item in result)
            {
                txtFirstName.Text = item.FirstName;
                txtLastName.Text = item.LastName;
                txtEmail.Text = item.UserName;
                txtPassword.Text = item.Password;
                txtProfileAge.Text = item.Age.ToString();
                txtProfileHeight.Text = item.Height.ToString();
                txtProfileWeight.Text = item.Weight.ToString();
                txtProfileGender.Text = item.Gender == true ? "Men" : "Women";
                txtProfileBmr.Text = BMR(item.Weight, item.Height, item.Age, item.Gender);
                txtProfileBmi.Text = BMI(item.Weight, item.Height).Substring(0, 8);

            }

        }

        private string BMR(decimal weight, int height, int age, bool gender) // Bazal metabolizma oranı hesaplar.
        {
            if (gender == true)
            {

                double bmr = (66.5 + ((13.75 * (double)weight) + (5.0 * height) - (6.77 * age)));
                return bmr.ToString();
            }
            else
            {

                double bmr = (655.1 + (((9.56) * (double)weight) + (1.85 * height) - (4.67 * age)));
                return bmr.ToString();
            }

        }
        private string BMI(decimal weight, int height) // Vücud-kitle endeksi hesaplar.
        {
            double _weightd = Convert.ToDouble(weight);
            double bmi = (_weightd / (double)Math.Pow(height, 2)*10000);
            return bmi.ToString();
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)// Kullanıcının profil sayfasında bilgilerini güncellemesini sağlar.
        {
            try
            {
                var result = _context.UserDetails.Where(x => x.User.UserName == txtEmail.Text).ToList();

                foreach (var item in result)
                {
                    item.Age = int.Parse(txtProfileAge.Text.Trim());
                    item.Weight = decimal.Parse(txtProfileWeight.Text.Trim());
                    item.Height = int.Parse(txtProfileHeight.Text.Trim());
                    item.User.Password = txtPassword.Text;
                }
                _context.SaveChanges();

                MessageBox.Show("Informations Update is Successful.");
            }
            catch (Exception)
            {

                MessageBox.Show("Please Check Your Informations.");
            }
        }
        private void GetMealType() // Öğün bilgisini databaseden combobox a gönderir.
        {
            var result = from mt in _context.MealTypes
                         select new
                         {
                             mt.MealTypeName
                         };
            foreach (var item in result)
            {
                cBoxMealType.Items.Add(item.MealTypeName.ToString());
            }
        }


        private void DeleteRow(object sender, EventArgs e)// Check listesinde seçili satırı siler.
        {
            if (listViewCheck.SelectedItems.Count > 0)
            {
                listViewCheck.Items.Remove(listViewCheck.SelectedItems[0]);
            }
        }

        private void lblRefresh_Click(object sender, EventArgs e)// Check listesini temizler..
        {
            listViewCheck.Items.Clear();
        }
        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            CreateMeal();
            CreateMealDetails();
        }// Kullanıcının eklediği öğünü ve yediği ürünleri database e ekler. 
        private void CreateMeal() // Kullanıcının eklediği öğün bilgisini database e gönderir.
        {
            if (cBoxMealType.SelectedItem != null && listViewCheck.Items.Count > 0)
            {
                Meal meal = new Meal();
                var resultMealTypeID = _context.MealTypes.Where(x => x.MealTypeName == cBoxMealType.SelectedItem.ToString()).Select(x => x.MealTypeID).First();
                var resultUserID = _context.Users.Where(x => x.UserName == txtEmail.Text.Trim()).Select(x => x.UserID).First();

                meal.MealDate = DateTime.Now;
                meal.UserID = resultUserID;
                meal.MealTypeID = resultMealTypeID;
                _context.Meals.Add(meal);
                _context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Please Choose Your Meal Information and Foods");
            }

        }
        private void CreateMealDetails() // Kullanıcının eklediği öğündeki yediği food bilgisini database e gönderir.
        {
            if (cBoxMealType.SelectedItem != null && listViewCheck.Items.Count > 0)
            {
                var resultMealID = _context.Meals.OrderByDescending(x => x.MealID).Select(x => x.MealID).First();


                for (int i = 0; i < listViewCheck.Items.Count; i++)
                {
                    string item = listViewCheck.Items[i].SubItems[0].Text;
                    var resultFoodID = _context.Foods.Where(x => x.FoodName == item).Select(x => x.FoodID).First();

                    MealDetail mealDetail = new MealDetail();

                    mealDetail.MealID = resultMealID;
                    mealDetail.FoodID = resultFoodID;
                    mealDetail.Count = int.Parse(listViewCheck.Items[i].SubItems[1].Text.Trim());

                    var resultCalorie = _context.Foods.Where(x => x.FoodID == resultFoodID).Select(x => x.Calorie).First();
                    mealDetail.Calorie = (decimal)resultCalorie * mealDetail.Count;
                    _context.MealDetails.Add(mealDetail);
                }
                _context.SaveChanges();
                listViewCheck.Items.Clear();
            }


        }
        private void btnListDetails_Click(object sender, EventArgs e) // Kullanıcının Günlük Raporunu Görüntüler.
        {
            listViewBreakfast.Items.Clear();
            listViewLunch.Items.Clear();
            listViewDinner.Items.Clear();
            listViewSnack.Items.Clear();

            decimal breakfastTotal = 0;
            decimal lunchTotal = 0;
            decimal dinnerTotal = 0;
            decimal snackTotal = 0;
            decimal total = 0;
            var userID = _context.Users.Where(x => x.UserName == txtEmail.Text).Select(x => x.UserID).First();

            var result = _context.MealDetails.Where(x => x.Meal.MealDate.Day == dtSelectedDate.Value.Day && x.Meal.UserID == userID)
                .Select(x => new
                {
                    FoodName = x.Food.FoodName,
                    Count = x.Count,
                    Calorie = x.Calorie,
                    FoodCalorie = x.Calorie / x.Count,
                    MealTypeID = x.Meal.MealTypeID,
                }).ToList();

            foreach (var item in result)
            {
                switch (item.MealTypeID)
                {
                    case 1:
                        string[] breakfast = { item.FoodName, item.Count.ToString(), item.Calorie.ToString() };
                        var breakfastItems = new ListViewItem(breakfast);
                        listViewBreakfast.Items.Add(breakfastItems);
                        breakfastTotal += item.Calorie;
                        lblBreakfastTotal.Text = $"{breakfastTotal}  k/cal";
                        break;
                    case 2:
                        string[] lunch = { item.FoodName, item.Count.ToString(), item.Calorie.ToString() };
                        var lunchItems = new ListViewItem(lunch);
                        listViewLunch.Items.Add(lunchItems);
                        lunchTotal += item.Calorie;
                        lblLunchTotal.Text = $"{lunchTotal}  k/cal";
                        break;
                    case 3:
                        string[] dinner = { item.FoodName, item.Count.ToString(), item.Calorie.ToString() };
                        var dinnerItems = new ListViewItem(dinner);
                        listViewDinner.Items.Add(dinnerItems);
                        dinnerTotal += item.Calorie;
                        lblDinnerTotal.Text = $"{dinnerTotal}  k/cal";
                        break;
                    case 4:
                        string[] snack = { item.FoodName, item.Count.ToString(), item.Calorie.ToString() };
                        var snackItem = new ListViewItem(snack);
                        listViewSnack.Items.Add(snackItem);
                        snackTotal += item.Calorie;
                        lblSnackTotal.Text = $"{snackTotal}  k/cal";
                        break;

                }

            }
            total = breakfastTotal + lunchTotal + dinnerTotal + snackTotal;
            lblTotal.Text = $"{total}  k/cal";

            var maxCalorie = _context.MealDetails.Where(x => x.Meal.MealDate.Day == dtSelectedDate.Value.Day && x.Meal.UserID == userID)
                .Select(x => x.Calorie / x.Count).OrderByDescending(x => x).FirstOrDefault();
            lblMaxCalorie.Text = $"{decimal.Round(maxCalorie, 2)}  k/cal";

            var maxCalorieMealType = _context.MealDetails.Where(x => x.Calorie / x.Count == maxCalorie)
                .Select(x => x.Meal.MealType.MealTypeName).FirstOrDefault();
            lblMealTypeHighest.Text = $"{maxCalorieMealType}";

            var minCalorie = _context.MealDetails.Where(x => x.Meal.MealDate.Day == dtSelectedDate.Value.Day && x.Meal.UserID == userID)
                .Select(x => x.Calorie / x.Count).OrderBy(x => x).FirstOrDefault();
            lblMinCalorie.Text = $"{decimal.Round(minCalorie, 2)}  k/cal";

            var minCalorieMealType = _context.MealDetails.Where(x => x.Calorie / x.Count == minCalorie)
                .Select(x => x.Meal.MealType.MealTypeName).FirstOrDefault();
            lblMealTypeLowest.Text = $"{minCalorieMealType}";
        }
        private void btnListWeaklyReport_Click(object sender, EventArgs e) // Kullanıcının Haftalık Raporunu Görüntüler.
        {
            listViewWeekly.Items.Clear();
            
            var userID = _context.Users.Where(x => x.UserName == txtEmail.Text).Select(x => x.UserID).First();

            var result = _context.MealDetails.GroupBy(x => new { x.Meal.MealDate, x.Meal.MealType.MealTypeName, x.Meal.UserID })
                .Select(x => new
                {
                    Date = x.Key.MealDate,
                    User = x.Key.UserID,
                    MealTypee = x.Key.MealTypeName,      
                    Calorie = x.Sum(y => y.Calorie)

                }).Where(x => x.Date >= dtSelectDateWeakly1.Value && x.Date <= dtSelectDateWeakly2.Value && x.User == userID)
                .GroupBy(x => new { x.Date, x.MealTypee, x.Calorie })
                .Select(x => new { DayDate = x.Key.Date, MealTypee = x.Key.MealTypee, Calorie = x.Key.Calorie })
                .OrderBy(x => new { x.DayDate, x.Calorie }).ToList();
            foreach (var item in result)
            {
                string[] weakly = { $"{item.DayDate.Day}.{item.DayDate.Month}.{item.DayDate.Year}", item.MealTypee, item.Calorie.ToString() };
                var weaklyItems = new ListViewItem(weakly);
                listViewWeekly.Items.Add(weaklyItems);
            }

            try
            {
                var maxCalorieWeakly = result.Max(x => x.Calorie);
                lblMostCalorieMealWeakly.Text = $"{maxCalorieWeakly} k/cal";

                var minCalorieWeakly = result.Min(x => x.Calorie);
                lblMinCalorieMealWeakly.Text = $"{minCalorieWeakly} k/cal";

                var totalWeaklyCalorie = result.GroupBy(x => new { x.DayDate.Day, x.Calorie }).Sum(x => x.Key.Calorie);
                lblTotalWeaklyCalorie.Text = $"{totalWeaklyCalorie} k/cal";

                var maxCalorieForDayWeakly = _context.MealDetails.Select(x => new { x.Meal.MealDate.Day, x.MealID, x.Calorie })
               .GroupBy(x => new { x.Day, x.Calorie }).Where(x=> x.Key.Day==x.Key.Day).Select(x => new { calorie = x.Sum(y => y.Calorie), x.Key.Day }).ToList()
               .Select(x => new
               {
                   calori = x.calorie,
                   day = x.Day
               }).OrderByDescending(x => x.calori).First();
                lblMaxCalorieForDayWeakly.Text = $"{maxCalorieForDayWeakly.calori}  k/cal";

                var eatenMaxFood = _context.MealDetails.GroupBy(x => new { x.Food.FoodID, x.Count, x.Food.FoodName }).Select(x => new { x.Key.FoodName, x.Key.Count })
                    .OrderByDescending(x => x.Count).First();
                lblEatenFoodMax.Text = $"{eatenMaxFood.FoodName}, Count =  {eatenMaxFood.Count}";

                var eatenMinFood = _context.MealDetails.GroupBy(x => new { x.Food.FoodID, x.Count, x.Food.FoodName }).Select(x => new { x.Key.FoodName, x.Key.Count })
                    .OrderBy(x => x.Count).First();
                lblEatenFoodMin.Text = $"{eatenMinFood.FoodName}, Count =  {eatenMinFood.Count}";

                var theMostEatenFoodType = _context.MealDetails.GroupBy(x => new { x.Food.Category.CategoryName, x.Count })
                    .OrderByDescending(x => x.Key.Count)
                    .Select(x => new
                    {
                        Countt = x.Sum(y => y.Count),
                        CategoryNamee = x.Key.CategoryName,
                    }).First();
                lblTheMostEatenFoodType.Text = $"{theMostEatenFoodType.CategoryNamee}";

                var theLeastEatenFoodType = _context.MealDetails.GroupBy(x => new { x.FoodID, x.Count, x.Food.FoodName, x.Food.Category.CategoryName })
                    .OrderBy(x => x.Key.Count)
                    .Select(x => new
                    {
                        FoodName = x.Key.FoodName,
                        Countt = x.Sum(y => y.Count),
                        CategoryNamee = x.Key.CategoryName,
                    }).First();
                lblTheLeastEatenFoodType.Text = $"{theLeastEatenFoodType.CategoryNamee}";


            }
            catch (Exception)
            {

                MessageBox.Show("No reports were found to list.");
            }
            

            

           
            
        }
        private void btnListMonthly_Click(object sender, EventArgs e)
        {
            listViewMonthly.Items.Clear();

            var userID = _context.Users.Where(x => x.UserName == txtEmail.Text).Select(x => x.UserID).First();

            var result = _context.MealDetails.GroupBy(x => new { x.Meal.MealDate, x.Meal.UserID })
                .Select(x => new
                {
                    Date = x.Key.MealDate,
                    User = x.Key.UserID,
                    Calorie = x.Sum(y => y.Calorie)

                }).Where(x => x.Date >= dtMonthly1.Value && x.Date <= dtMonthly2.Value && x.User == userID)
                .GroupBy(x => new { x.Date, x.Calorie })
                .Select(x => new { DayDate = x.Key.Date, Calorie = x.Key.Calorie })
                .OrderBy(x => new { x.DayDate, x.Calorie }).ToList();
            foreach (var item in result)
            {
                string[] monthly = { $"{item.DayDate.Day}.{item.DayDate.Month}.{item.DayDate.Year}", item.Calorie.ToString() };
                var monnthlyItem = new ListViewItem(monthly);
                listViewMonthly.Items.Add(monnthlyItem);
            }
        } //Kullanıcının Aylık Raporunu Görüntüler

        private void dtSelectDateWeakly1_ValueChanged(object sender, EventArgs e)
        {
            dtSelectDateWeakly2.Value = dtSelectDateWeakly1.Value.AddDays(7);
        }

        private void dtSelectDateWeakly2_ValueChanged(object sender, EventArgs e)
        {
            dtSelectDateWeakly1.Value = dtSelectDateWeakly2.Value.AddDays(-7);
        }



        #region Create Controls Master  

        private void CreateControls(TabPage tp, int sayi)  // Runtime controllerini oluşturur.
        {
            var result = _context.Foods.Where(x => x.CategoryID == sayi).Select(x => x.FoodName).ToList();

            flpMainControl = new FlowLayoutPanel();
            flpMainControl.Location = new Point(28, 28);
            flpMainControl.Size = new Size(510, 520);
            flpMainControl.BackColor = Color.Transparent;
            tp.Controls.Add(flpMainControl);

            for (int i = 0; i < result.Count; i++)
            {
                Button btn = new Button();
                btn.Name = $"btn{result[i]}";
                btn.Text = result[i].ToString();
                btn.Height = 100;
                btn.Width = 100;
                btn.Click += Btn_Click;


                flpMainControl.Controls.Add(btn);
            }
        }


        private void Btn_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            button.Controls.Clear();

            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Size = new Size(50, 30);
            numericUpDown.Location = new Point(10, 5);
            numericUpDown.Name = "num";
            numericUpDown.Value = 1;

            Button btnConfirm = new Button();
            btnConfirm.Size = new Size(75, 26);
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.BackColor = Color.DarkOliveGreen;
            btnConfirm.Text = "✓";
            btnConfirm.Font = new Font("Microsoft Sans Serif", 13);
            btnConfirm.TextAlign = ContentAlignment.MiddleCenter;
            btnConfirm.Location = new Point(13, 60);
            btnConfirm.Click += BtnConfirm_Click;

            Button btnCancel = new Button();
            btnCancel.Size = new Size(23, 23);
            btnCancel.Name = button.Name;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.Text = "X";
            btnCancel.Font = new Font("Microsoft Sans Serif", 10);
            btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            btnCancel.Location = new Point(67, numericUpDown.Location.Y);

            button.Controls.Add(numericUpDown);
            button.Controls.Add(btnConfirm);
            button.Controls.Add(btnCancel);


        }

        private void BtnConfirm_Click(object sender, EventArgs e)// Seçilen yemekleri Check ekranına gönderir.
        {
            Button btn = (Button)sender;

            foreach (TabPage pages in tcMeal.TabPages)
            {
                foreach (var flp in pages.Controls)
                {
                    if (flp.GetType() == typeof(FlowLayoutPanel))
                    {
                        FlowLayoutPanel flp2 = (FlowLayoutPanel)flp;
                        foreach (Button item in flp2.Controls)
                        {
                            foreach (var nup in item.Controls)
                            {
                                if (nup.GetType() == typeof(NumericUpDown))
                                {
                                    NumericUpDown numericUpDown = (NumericUpDown)nup;

                                    if (numericUpDown.Value != 0)
                                    {
                                        string[] row = { item.Text, numericUpDown.Value.ToString() };
                                        var listViewItem = new ListViewItem(row);
                                        listViewCheck.Items.Add(listViewItem);
                                    }
                                    numericUpDown.Value = 0;
                                }
                            }
                        }
                    }
                }
            }
        }

        #endregion



        #region Help


        private void visibleLB(object sender)
        {
            Label label = (Label)sender;
            if (label.Visible)
            {
                label.Visible = false;
            }
            else
            {
                label.Visible = true;
            }

        }


        private void btnQuestion1_Click(object sender, EventArgs e)
        {
            visibleLB(lblAnswer1);
        }

        private void btnQuestion2_Click(object sender, EventArgs e)
        {
            visibleLB(lblAnswer2);
        }


        private void btnQuestion3_Click(object sender, EventArgs e)
        {
            visibleLB(lblAnswer3);
        }

        private void btnQuestion4_Click(object sender, EventArgs e)
        {
            visibleLB(lblAnswer4);
        }

        private void btnQuestion5_Click(object sender, EventArgs e)
        {
            visibleLB(lblAnswer5);
        }

        private void btnQuestion6_Click(object sender, EventArgs e)
        {
            visibleLB(lblAnswer6);
        }

        private void btnQuestion7_Click(object sender, EventArgs e)
        {
            visibleLB(lblAnswer7);
        }

        private void btnQuestion8_Click(object sender, EventArgs e)
        {
            visibleLB(lblAnswer8);
        }
        #endregion

        #region About
        private void btnTR_Click(object sender, EventArgs e)
        {
            lblEN.Visible = false;
            visibleLB(lblTR);
        }

        private void btnEN_Click(object sender, EventArgs e)
        {
            lblTR.Visible = false;
            visibleLB(lblEN);
        }




        #endregion

        
    }

}

