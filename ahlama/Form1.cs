using ahlama.Models.ollama;
using ahlama.Models.REST;
using ahlama.Services;
using ahlama.Services.REST;
using Newtonsoft.Json;


namespace ahlama
{
    public partial class Form1 : Form
    {
        ConfigForm configForm1 = new ConfigForm();
        RESTService _RESTService = new RESTService();
        ollamaService _ollamaService = new ollamaService();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            configForm1.URLBox.Text = Properties.Settings.Default["URL"].ToString();

            refreshModelList();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            OutputBox.AppendText($"[User] {InputBox.Text}{Environment.NewLine}");

            GenerateInput input = new GenerateInput()
            {
                model = ModelListBox.Text,
                prompt = InputBox.Text
            };

            //            
            CallRestInput inpt = new CallRestInput()
            {
                URL = $"{configForm1.URLBox.Text}api/generate",
                Method = "POST",
                accept = "application/json",
                BodyData = JsonConvert.SerializeObject(input)
            };

            RESTConfig config = new RESTConfig()
            {
                HTTPTimeOut = 60000,
            };

            //
            CallRestOutput result = _RESTService.CallREST(inpt, config);

            //            
            OutputBox.AppendText($"[BOT] {_ollamaService.processGenerateResponse(result.Output)}{Environment.NewLine}");


            InputBox.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configForm1.Show();
        }

        public void refreshModelList()
        {
            RESTConfig config = new RESTConfig()
            {
                HTTPTimeOut = 10000,
            };

            //            
            CallRestInput inpt = new CallRestInput()
            {
                URL = $"{configForm1.URLBox.Text}api/tags",
                Method = "GET",
                accept = "application/json"
            };

            OutputBox.AppendText($"[System] Attampting Connection to: {configForm1.URLBox.Text}{Environment.NewLine}");

            // Get Models installed on server
            CallRestOutput result = _RESTService.CallREST(inpt);

            TagsOutput tags = _ollamaService.ParseTags(result.Output);
            ModelListBox.Items.Clear();
            if (tags.models != null)
            {
                foreach (var model in tags.models)
                {
                    var modelName = model.name.Split(":")[0];
                    ModelListBox.Items.Add(modelName);
                }
                ModelListBox.SelectedIndex = 0;
            }            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (configForm1.hasChanged)
            {
                refreshModelList();
                configForm1.hasChanged = false;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (configForm1.hasChanged)
            {
                refreshModelList();
                configForm1.hasChanged = false;
            }
        }

        private void InputBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendButton.PerformClick();
            }
        }
    }
}
