using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace CyberSecurityBotGUI
{
    public partial class Form1 : Form
    {
        private List<string> taskLog = new List<string>();

        //  A Keyword-responses dictionary
        private Dictionary<string, string> nlpResponses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
{
    { "what is phishing", "Phishing is a type of scam where attackers trick you into revealing personal information." },
    { "how do i create a strong password", "Use a mix of upper/lowercase letters, numbers, and symbols. Avoid common words." },
    { "what is 2fa", "2FA (Two-Factor Authentication) adds an extra layer of security by requiring a second verification method." },
    { "why use antivirus", "Antivirus helps protect your system from malware and viruses." },
    { "what does a firewall do", "A firewall blocks unauthorized access to your network and devices." },
    { "how to spot a scam email", "Look for strange email addresses, poor spelling, and suspicious links." },
};

        // Quiz questions, options and correct answers
        private List<(string Question, string[] Options, char Answer)> quizData = new List<(string, string[], char)>
{
    ("What is a strong password?", new[] { "123456", "YourName", "P@ssw0rd123!", "password" }, 'C'),
    ("What is phishing?", new[] { "Fishing on a lake", "Scam emails to steal data", "Installing antivirus", "None" }, 'B'),
    ("Why use 2FA?", new[] { "To double login time", "To annoy users", "To improve security", "To encrypt data" }, 'C'),
    ("What does a firewall do?", new[] { "Block hackers", "Cook pizza", "Send emails", "Boost WiFi" }, 'A'),
};

        private int currentQuizIndex = 0;
        private char selectedOption = '\0';


        public Form1()
        {
            InitializeComponent();
        }

        // Event handlers
        private void Form1_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void button4_Click_1(object sender, EventArgs e) { }

        // Adds a Task
        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text.Trim();
            string description = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please enter a task title.", "Missing Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string task = $"[ ] {title}: {description}";
            if (checkBox1.Checked)
            {
                task += $" (Reminder set for {dateTimePicker1.Value.ToShortDateString()})";
            }

            listBox1.Items.Add(task);
            AddToLog($"Task added: '{title}'");

            textBox1.Clear();
            textBox2.Clear();
            checkBox1.Checked = false;
        }

        // Marks Task as Complete
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                string selected = listBox1.SelectedItem.ToString();
                if (!selected.StartsWith("[✓]"))
                {
                    string updated = "[✓]" + selected.Substring(3);
                    listBox1.Items[listBox1.SelectedIndex] = updated;
                    AddToLog($"Task completed: '{updated}'");
                }
                else
                {
                    MessageBox.Show("This task is already marked as complete.", "No Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a task to mark as complete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Deletes Tasks
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string taskToRemove = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(taskToRemove);
                AddToLog($"Task deleted: '{taskToRemove}'");
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // View Logs
        private void button4_Click(object sender, EventArgs e)
        {
            if (taskLog.Count == 0)
            {
                MessageBox.Show("No activity has been logged yet.", "Activity Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int count = Math.Min(10, taskLog.Count);
            var recentLogs = new List<string>();

            for (int i = taskLog.Count - count; i < taskLog.Count; i++)
            {
                recentLogs.Add($"{recentLogs.Count + 1}. {taskLog[i]}");
            }

            string logMessage = "Here’s a summary of recent actions:\n\n" + string.Join("\n", recentLogs);
            MessageBox.Show(logMessage, "Activity Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Chatbot interaction
        private void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = txtUserInput.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(userInput)) return;

            lstChatHistory.Items.Add("User: " + userInput);
            AddToLog($"User input: '{userInput}'");

            string response = "Sorry, I couldn't understand that. Try asking about passwords, 2FA, phishing, or firewalls.";

            foreach (var pair in nlpResponses)
            {
                if (userInput.Contains(pair.Key))
                {
                    response = pair.Value;
                    break;
                }
            }

            lstChatHistory.Items.Add("Bot: " + response);
            AddToLog($"Bot response: '{response}'");
            txtUserInput.Clear();
        }

        // Adds to activity log
        private void AddToLog(string message)
        {
            string timestamped = $"{DateTime.Now:HH:mm:ss dd-MM-yyyy} - {message}";
            taskLog.Add(timestamped);

            if (lstActivityLog != null)
                lstActivityLog.Items.Add(timestamped);
        }


        private void grpQuiz_Enter(object sender, EventArgs e)
        {

        }


        private void lblFeedback_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            if (selectedOption == '\0')
            {
                lblFeedback.Text = "Please select an answer.";
                return;
            }

            var correctAnswer = quizData[currentQuizIndex].Answer;
            if (selectedOption == correctAnswer)
            {
                lblFeedback.Text = "Correct!";
                AddToLog($"Quiz Q{currentQuizIndex + 1}: Correct answer selected.");
            }
            else
            {
                lblFeedback.Text = $"Wrong! Correct answer is {correctAnswer}.";
                AddToLog($"Quiz Q{currentQuizIndex + 1}: Wrong answer.");
            }
        }


        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            currentQuizIndex++;
            if (currentQuizIndex >= quizData.Count)
            {
                lblFeedback.Text = "Quiz finished.";
                btnSubmitAnswer.Enabled = false;
                btnNextQuestion.Enabled = false;
                return;
            }

            LoadQuizQuestion(currentQuizIndex);
        }
        private void LoadQuizQuestion(int index)
        {
            var (question, options, _) = quizData[index];
            lblQuestion.Text = question;
            rdoA.Text = "A. " + options[0];
            rdoB.Text = "B. " + options[1];
            rdoC.Text = "C. " + options[2];
            rdoD.Text = "D. " + options[3];

            selectedOption = '\0';
            rdoA.Checked = rdoB.Checked = rdoC.Checked = rdoD.Checked = false;
            lblFeedback.Text = "";
        }

        private void rdoA_CheckedChanged(object sender, EventArgs e) { selectedOption = 'A'; }
        private void rdoB_CheckedChanged(object sender, EventArgs e) { selectedOption = 'B'; }
        private void rdoC_CheckedChanged(object sender, EventArgs e) { selectedOption = 'C'; }
        private void rdoD_CheckedChanged(object sender, EventArgs e) { selectedOption = 'D'; }

        private void txtLogSearch_TextChanged(object sender, EventArgs e)
        {
            string filter = txtLogSearch.Text.Trim().ToLower();
            lstActivityLog.Items.Clear();

            foreach (var entry in taskLog)
            {
                if (entry.ToLower().Contains(filter))
                    lstActivityLog.Items.Add(entry);
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear all log entries?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                taskLog.Clear();
                lstActivityLog.Items.Clear();
            }
        }

        private void btnExportLog_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text File|*.txt";
            save.Title = "Export Activity Log";

            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(save.FileName, taskLog);
                MessageBox.Show("Log exported successfully.");
            }
        }


    }


}



