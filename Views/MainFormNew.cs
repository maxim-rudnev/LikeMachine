using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LikeMachine.Views
{
    public partial class MainFormNew : MetroForm
    {
        public MainFormNew()
        {
            InitializeComponent();

            metroGrid1.Columns.AddRange(
                new DataGridViewTextBoxColumn()
                {
                    Name = "UserLink",
                    HeaderText = "UserLink",
                    Width = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "LastName",
                    HeaderText = "Фамилия",
                    Width = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "FirstName",
                    HeaderText = "Имя",
                    Width = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "MaidenName",
                    HeaderText = "Отчество",
                    Width = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Age",
                    HeaderText = "Возраст",
                    Width = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "BDate",
                    HeaderText = "Дата рождения",
                    Width = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "City",
                    HeaderText = "Город",
                    Width = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Sex",
                    HeaderText = "Пол",
                    Width = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Status",
                    HeaderText = "Статус",
                    Width = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Relation",
                    HeaderText = "Семейное положение",
                    Width = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "HomePhone",
                    HeaderText = "Домашний телефон",
                    Width = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "MobilePhone",
                    HeaderText = "Мобильный телефон",
                    Width = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Interests",
                    HeaderText = "Интересы",
                    Width = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Music",
                    HeaderText = "Музыка",
                    Width = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Movies",
                    HeaderText = "Фильмы",
                    Width = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Activities",
                    HeaderText = "Деятельность",
                    Width = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Books",
                    HeaderText = "Книги",
                    Width = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Games",
                    HeaderText = "Игры",
                    Width = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "About",
                    HeaderText = "О себе",
                    Width = 100
                }
            );
        }
    }
}
