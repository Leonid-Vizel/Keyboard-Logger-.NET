using System.Windows.Forms;

namespace KeyboardLogger
{
    public partial class MainForm : Form
    {
        private KeyboardListener _listener;
        public MainForm()
        {
            _listener = new KeyboardListener();
            InitializeComponent();
            _listener.HookKeyboard();
            _listener.OnKeyPressed += OnPressCalled;
        }

        private void OnPressCalled(object sender, KeyPressedArgs e)
            => loggerTextBox.Text += $" {e.KeyPressed.ToString()}";

        private void OnDisabledToggle(object sender, System.EventArgs e)
            => loggerTextBox.Enabled = !disabledToggle.Checked;

        private void OnLoggingToggle(object sender, System.EventArgs e)
        {
            if (loggingToggle.Checked)
            {
                _listener.OnKeyPressed += OnPressCalled;
            }
            else
            {
                _listener.OnKeyPressed -= OnPressCalled;
            }
        }
    }
}
