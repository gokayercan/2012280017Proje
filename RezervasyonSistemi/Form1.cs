using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezervasyonSistemi
{
    public partial class Form1 : Form
    {
        Rezervasyon rezervasyon = new Rezervasyon();//Yeni bir rezervasyon nesnesi yaratıyoruz

        public Form1()
        {
            InitializeComponent();
        }
        //Değişkenler Atadık
        int OdaNo = 0;
        public string gecici;
        


        private void BaslatButton_Click(object sender, EventArgs e)//Başlat butonuna basıldığında visible durum değişimleri yapıldı
        {
            label4.Visible = true;
            BaslatButton.Visible = false;
            RezervasyonButton.Visible = true;
            RezervasyoniptalButton.Visible = true;
            RezervasyonkontrolButton.Visible = true;
            ButunrezervasyonlarButton.Visible = true;
            SifirlaButton.Visible = true;
           
        }

        private void RezervasyonButton_Click(object sender, EventArgs e)//Rezervasyon butonuna basıldığında visible durum değişimleri yapıldı
        {
            RezervasyongBox.Visible = true;
            groupBox2.Visible = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)//Form1 yüklendiğinde olan visible durum değişimleri 
        {
            girisdateTimePicker.MinDate = DateTime.Now;
            RezervasyongBox.Visible = false;
            RezervasyonButton.Visible = false;
            RezervasyoniptalButton.Visible = false;
            RezervasyonkontrolButton.Visible = false;
            ButunrezervasyonlarButton.Visible = false;
            SifirlaButton.Visible = false;
        }

        private void CikisButton_Click(object sender, EventArgs e)
        {
            this.Close();//Çıkış butonuyla programı sonlandırıyoruz
        }
        
        private void TekYatak1rButton_CheckedChanged(object sender, EventArgs e)//62-157 satırları arasında seçilen radio butona göre yapılan visible durum değişimleri 
        {
            if (TekYatak1rButton.Checked)
            {
                groupBox1.Visible = true;
                Oda11rButton.Visible = true;
                Oda12rButton.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
                Oda11rButton.Visible = false;
                Oda12rButton.Visible = false;
            }
        }

        private void TekYatak2rButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TekYatak2rButton.Checked)
            {
                groupBox1.Visible = true;
                Oda13rButton.Visible = true;
                Oda14rButton.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
                Oda13rButton.Visible = false;
                Oda14rButton.Visible = false;
            }
        }

        private void CiftYatak1rButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CiftYatak1rButton.Checked)
            {
                groupBox1.Visible = true;
                Oda21rButton.Visible = true;
                Oda22rButton.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
                Oda21rButton.Visible = false;
                Oda22rButton.Visible = false;
            }
        }

        private void CiftYatak2rButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CiftYatak2rButton.Checked)
            {
                groupBox1.Visible = true;
                Oda23rButton.Visible = true;
                Oda24rButton.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
                Oda23rButton.Visible = false;
                Oda24rButton.Visible = false;
            }
        }

        private void CiftKisilik1rButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CiftKisilik1rButton.Checked)
            {
                groupBox1.Visible = true;
                Oda31rButton.Visible = true;
                Oda32rButton.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
                Oda31rButton.Visible = false;
                Oda32rButton.Visible = false;
            }
        }

        private void CiftKisilik2rButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CiftKisilik2rButton.Checked)
            {
                groupBox1.Visible = true;
                Oda33rButton.Visible = true;
                Oda34rButton.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
                Oda33rButton.Visible = false;
                Oda34rButton.Visible = false;
            }
        
        }

        private void RezervasyoniptalButton_Click(object sender, EventArgs e)//Rezervasyon İptal butonuna tıklanınca yapılan visible durum değişimleri ve nesnelerin text değişimleri
        {
            RezervasyongBox.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox2.Text = "Rezervasyon İptali";
            button1.Text = "İptal Et";
        }

        private void RezervasyonkontrolButton_Click(object sender, EventArgs e)//Rezervasyon Kontrolü butonuna tıklanınca yapılan visible durum değişimleri ve nesnelerin text değişimleri
        {
            RezervasyongBox.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox2.Text = "Rezervasyon Kontrolü";
            button1.Text = "Kontrol Et";
            
        }

        private void button1_Click(object sender, EventArgs e)//Rezervasyon kontrolü ve iptali için aynı textbox ve buttonu kullandık. Farklı durumlara göre farklı işlemler yapmakta.
        {
            int sayac = 0;
                        
                if (button1.Text == "İptal Et")//Rezervasyon iptali için butonda iptal et yazıyorsa tetiklenen kısım
                {
                    try
                    {
                        gecici = listetBox.Text;//bütün rezervasyonların yazılı olduğu textboxı gecici değişkenine atadık.
                    string[] metin = gecici.Split(',');// split kullanarak satırları ayırdık
                    foreach (string okunan in metin)
                        {

                            if (okunan != null)
                            {
                                if (textBox3.Text == okunan.Substring(0, 3))//textboxa girilen değer okunan değere eşitse rezervasyonu iptal ettik
                            {
                                    metin[sayac] = "";
                                    MessageBox.Show("Rezervasyon İptal Edildi");
                                    listetBox.Clear();
                                    for (int i = 0; i < metin.Length; i++)
                                    {
                                        if (metin[i] != "")
                                            listetBox.Text += metin[i] + ",";
                                    }
                                }
                            }

                            sayac++;

                        }
                        
                    }
                    catch (Exception)
                    {

                    }

                }
            else//Rezervasyon kontrolü için butonda iptal et yazmıyorsa tetiklenen kısım
            {
                    try
                    {
                        gecici = listetBox.Text;//bütün rezervasyonların yazılı olduğu textboxı gecici değişkenine atadık.
                        string[] metin = gecici.Split(',');// split kullanarak satırları ayırdık
                    foreach (string okunan in metin)
                    {

                        if (okunan != null)
                        {
                            if (textBox3.Text == okunan.Substring(0, 3))//textboxa girilen değer okunan değere eşitse kontrolün sonucunu kullanıcıya verdik
                            {
                                MessageBox.Show(okunan);
                            }
                        }
                    }
                   
                }
                    catch (Exception)
                    {

                    }
            }
        }

        

        private void ButunrezervasyonlarButton_Click(object sender, EventArgs e)//Bütün Rezervasyonlar butonuna tıklanınca yapılan visible durum değişimleri
        {
            RezervasyongBox.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
        }

        private void RezervasyonTamamlaButton_Click(object sender, EventArgs e)
        {
            rezervasyon.RezervasyonOlustur(AdSoyadtBox.Text, teltBox.Text, girisdateTimePicker.Value.Date, cikisdateTimePicker.Value.Date, OdaNo);//Rezervasyon isteğini rezervasyon sınıfına iletiyor
            listetBox.Text += rezervasyon.RezervasyonNo +"\t" + OdaNo +"\t"+ AdSoyadtBox.Text + "\t" + teltBox.Text + "\t_" + girisdateTimePicker.Value + "\t_" + cikisdateTimePicker.Value + "\t" +  "\r\n,";//yapılan rezervasyonu textboxa kaydediyor

            MessageBox.Show("Oda Numarası:" + OdaNo + " Rezervasyon Kodu:" + rezervasyon.RezervasyonNo);

            /*try
            {
                gecici = listetBox.Text;
                string[] metin = gecici.Split('_','_',',');
                foreach (string okunan in metin)
                {
                
                            MessageBox.Show(okunan);
                            
                }
            }
            catch (Exception)
            {

            }*/


        }



        private void Oda11rButton_CheckedChanged(object sender, EventArgs e)//291-386 satırları arasında seçilen radyo butuna göre oda numarasını belirliyor
        {
            if (Oda11rButton.Checked)
            {
                OdaNo = 11;
            }
            
        }

        private void Oda12rButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Oda12rButton.Checked)
            {
                OdaNo = 12;
            }
        }

        private void Oda13rButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Oda13rButton.Checked)
            {
                OdaNo = 13;
            }
        }

        private void Oda14rButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Oda14rButton.Checked)
            {
                OdaNo = 14;
            }
        }

        private void Oda21rButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Oda21rButton.Checked)
            {
                OdaNo = 21;
            }
        }

        private void Oda22rButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Oda22rButton.Checked)
            {
                OdaNo = 22;
            }
        }

        private void Oda23rButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Oda23rButton.Checked)
            {
                OdaNo = 23;
            }
        }

        private void Oda24rButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Oda24rButton.Checked)
            {
                OdaNo = 24;
            }
        }

        private void Oda31rButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Oda31rButton.Checked)
            {
                OdaNo = 31;
            }
        }

        private void Oda32rButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Oda32rButton.Checked)
            {
                OdaNo = 32;
            }
        }

        private void Oda33rButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Oda33rButton.Checked)
            {
                OdaNo = 33;
            }
        }

        private void Oda34rButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Oda34rButton.Checked)
            {
                OdaNo = 34;
            }
        }

        private void girisdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
            cikisdateTimePicker.MinDate = girisdateTimePicker.Value;//Çıkış Tarihinin giriş tarihinden küçük olmasını engelliyor
        }

        private void SifirlaButton_Click(object sender, EventArgs e)//Bütün Rezervasyonların tutulduğu TextBox'ı temizliyor
        {
            DialogResult secenek = MessageBox.Show("Tüm Rezervasyonları Silmek İstediğinize Emin Misiniz?", "UYARI!", MessageBoxButtons.OKCancel);
            if (secenek == DialogResult.OK)
            {
                listetBox.Text = "";
                MessageBox.Show("Tüm Rezervasyonlar Silindi!");
            }
            
           
        }

        private void teltBox_KeyPress(object sender, KeyPressEventArgs e)//TextBoxa sadece sayı girilmesini sağlıyor
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void AdSoyadtBox_KeyPress(object sender, KeyPressEventArgs e)//TextBoxa sadece harf ve boşluk karakteri girilmesini sağlıyor
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) && !char.IsWhiteSpace(e.KeyChar);
        }
    }
}
