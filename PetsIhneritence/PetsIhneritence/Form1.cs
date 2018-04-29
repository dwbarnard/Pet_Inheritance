using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PetsInheritance
{
	public partial class Form1 : Form
	{
		private static String petType = "Dog";		

		public Form1()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			Pet myPet = null;
				switch(petType) {
				case "Dog" :
					myPet = new Dog(inputTextBox.Text);
					break;
				case "Cat" :
					myPet = new Cat(inputTextBox.Text);
					break;
				case "Bird" :
					myPet = new Bird(inputTextBox.Text);
					break;
			}
						
			petListBox.Items.Add(myPet);
			petListBox.DisplayMember = "petName";
			inputTextBox.Clear();
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			petListBox.Items.Clear();
		}

		private void Button5_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (petListBox.SelectedIndex != -1)
				petListBox.Items.RemoveAt(
				   petListBox.SelectedIndex);
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void petListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			petInfoTextBox.Clear();

			Pet selectedPet = petListBox.SelectedItem as Pet;
			if (selectedPet != null)
			{
				petInfoTextBox.Text = selectedPet.Display();
			}
		}

		private void dogRadioBtn_CheckedChanged(object sender, EventArgs e)
		{
			String result = null;
			foreach (Control control in this.petTypeGroupBox.Controls)
			{
				if (control is RadioButton)
				{
					RadioButton radio = control as RadioButton;
					if (radio.Checked)
					{
						result = radio.Text;
					}
				}
			}
			petType = result;
		}

		private void petTypeGroupBox_Enter(object sender, EventArgs e)
		{
			
		}

		private void inputTextBox_TextChanged(object sender, EventArgs e)
		{
			// do nothing except eat the event 
		}

		private void catRadioBtn_CheckedChanged(object sender, EventArgs e)
		{
			String result = null;
			foreach (Control control in this.petTypeGroupBox.Controls)
			{
				if (control is RadioButton)
				{
					RadioButton radio = control as RadioButton;
					if (radio.Checked)
					{
						result = radio.Text;
					}
				}
			}
			petType = result;
		}

		private void birdRadioBtn_CheckedChanged(object sender, EventArgs e)
		{
			String result = null;
			foreach (Control control in this.petTypeGroupBox.Controls)
			{
				if (control is RadioButton)
				{
					RadioButton radio = control as RadioButton;
					if (radio.Checked)
					{
						result = radio.Text;
					}
				}
			}
			petType = result;
		}
	}
}
