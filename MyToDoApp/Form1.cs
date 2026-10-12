namespace MyToDoApp
{
    public partial class Form1 : Form
    {
        List<string> MyTasks = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            MyTasks.Add(TaskTBX.Text);

            TasksLbx.DataSource = null; //Delete the previous data source to avoid duplication
            TasksLbx.DataSource = MyTasks;

        }
    }
}
