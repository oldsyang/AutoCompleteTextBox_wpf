using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using AutoCompleteTextBox.Models;
using MyWPFUI.Controls;

namespace AutoCompleteTextBox.ViewModels
{
    public class MainWindowViewModel: MyPropertyChanged
    {
        #region Property
        public ObservableCollection<StudentModel> Collection { get; set; }
        private StudentModel _selectedStudentModel;

        public StudentModel SelectedStudentModel
        {
            get { return _selectedStudentModel; }
            set
            {
                _selectedStudentModel = value;
                OnPropertyChanged("SelectedStudentModel");
            }
        }
        #endregion

        #region Constructor

        public MainWindowViewModel()
        {
            Collection=new ObservableCollection<StudentModel>();
            Collection.Add(new StudentModel() {Name = "张山",Age = 12,Sex = "男女",Code = "238394573453"});
            Collection.Add(new StudentModel() {Name = "李四",Age = 12,Sex = "男",Code = "34534"});
            Collection.Add(new StudentModel() {Name = "王二麻子", Age = 12,Sex = "女",Code = "3435234"});
            Collection.Add(new StudentModel() {Name = "赵六", Age = 12,Sex = "女",Code = "4545454545"});
            Collection.Add(new StudentModel() {Name = "离京", Age = 12, Sex = "女", Code = "4543645"});
            Collection.Add(new StudentModel() {Name = "离京2", Age = 12, Sex = "女", Code = "456454"});
            Collection.Add(new StudentModel() { Name = "张山1", Age = 12, Sex = "男女", Code = "238394573453" });
            Collection.Add(new StudentModel() { Name = "李四1", Age = 24, Sex = "男", Code = "34534" });
            Collection.Add(new StudentModel() { Name = "王二麻子2", Age = 12, Sex = "女", Code = "3435234" });
            Collection.Add(new StudentModel() { Name = "赵六2", Age = 12, Sex = "女", Code = "4545454545" });
            Collection.Add(new StudentModel() { Name = "离京2", Age = 12, Sex = "女", Code = "4543645" });
            Collection.Add(new StudentModel() { Name = "离京22", Age = 12, Sex = "女", Code = "456454" });
            Collection.Add(new StudentModel() { Name = "qiutian", Age = 12, Sex = "女", Code = "456454" });
            Collection.Add(new StudentModel() { Name = "women", Age = 12, Sex = "女", Code = "456454" });
            Collection.Add(new StudentModel() { Name = "jhon", Age = 12, Sex = "女", Code = "456454" });

        }

        #endregion

        #region Command Handlers

        #endregion

        #region Public

        #endregion

        #region Private

        #endregion
    }
}
