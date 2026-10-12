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

        private void TasksLbx_Click(object sender, EventArgs e)
        {
            //if(TasksLbx.SelectedIndex == -1)
               // return;

            if(MyTasks.Count <=0)
                return;

            MyTasks.RemoveAt(TasksLbx.SelectedIndex);

            TasksLbx.DataSource = null;
            TasksLbx.DataSource = MyTasks;
        }
    }
}
