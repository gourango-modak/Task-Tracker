using Entity;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void pBoxAddTaskView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User uN = new User();
            if (textBox1.Text != null && !(textBox1.Text.Equals("Name...........")))
            {
                uN.UserName = textBox1.Text;
                if (textBox2.Text != null && !(textBox2.Text.Equals("Email...........")))
                {
                    uN.Email = textBox2.Text;
                    if (textBox3.Text != null && !(textBox3.Text.Equals("Phone...........")))
                    {
                        uN.Phone = textBox3.Text;
                        if (textBox4.Text != null && !(textBox4.Text.Equals("Password...........")))
                        {
                            uN.Password = textBox4.Text;

                            UserSer uSr = new UserSer();
                            uSr.Insert(uN);
                            uSr = new UserSer();
                            int uid = uSr.GetUserID(uN.UserName);
                            CategorySer cgS = new CategorySer();
                            
                            Category cat = new Category();
                            cat.Name = "Inbox";
                            cat.UserID = uid;
                            cat.Color = 0;
                            cgS.Insert(cat,LogIn.user_ID);

                            cat = new Category();
                            cat.Name = "Today";
                            cat.UserID = uid;
                            cat.Color = 0;
                            cgS.Insert(cat,LogIn.user_ID);

                            cat = new Category();
                            cat.Name = "Next 7 Day";
                            cat.UserID = uid;
                            cat.Color = 0;
                            cgS.Insert(cat, LogIn.user_ID);

                            this.Close();
                        }
                            
                        else
                            MessageBox.Show("Please Input Your Password");
                    }
                        
                    else
                        MessageBox.Show("Please Input Your Phone");
                }
                    
                else
                    MessageBox.Show("Please Input Your Email");
            }
                
            else
                MessageBox.Show("Please Input Your Name");
            
            
            

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }
    }
}
