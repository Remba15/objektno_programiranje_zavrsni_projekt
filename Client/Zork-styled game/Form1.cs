using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Zork_styled_game
{
    public partial class Form1 : Form
    {
        TcpClient client = new TcpClient();
        NetworkStream stream;
        string command = "";

        byte[] prepareForTransmission(string data)
        {
            int byteCount = Encoding.ASCII.GetByteCount(data);
            byte[] sendData = new byte[byteCount];
            sendData = Encoding.ASCII.GetBytes(data);
            return sendData;
        }

        string prepareForReceiving()
        {
            byte[] receivedData = new byte[client.ReceiveBufferSize];
            int bytesRead = stream.Read(receivedData, 0, client.ReceiveBufferSize);
            string ReceivedMessage = Encoding.ASCII.GetString(receivedData, 0, bytesRead);
            Console.WriteLine("Received message: " + ReceivedMessage);
            if (ReceivedMessage.Contains("+Winding Key+") == true)
            {
                listBoxInventory.Items.Add("Winding Key");
            }
            if (ReceivedMessage.Contains("-Winding Key-") == true)
            {
                listBoxInventory.Items.Remove("Winding Key");
            }
            if (ReceivedMessage.Contains("+Toy Car+") == true)
            {
                listBoxInventory.Items.Add("Toy Car");
            }
            if (ReceivedMessage.Contains("-Toy Car-") == true)
            {
                listBoxInventory.Items.Remove("Toy Car");
            }
            if (ReceivedMessage.Contains("+Toy Cubes+") == true)
            {
                listBoxInventory.Items.Add("Toy Cubes");
            }
            if (ReceivedMessage.Contains("-Toy Cubes-") == true)
            {
                listBoxInventory.Items.Remove("Toy Cubes");
            }
            if (ReceivedMessage.Contains("+Toy Horse+") == true)
            {
                listBoxInventory.Items.Add("Toy Horse");
            }
            if (ReceivedMessage.Contains("-Toy Horse-") == true)
            {
                listBoxInventory.Items.Remove("Toy Horse");
            }
            if (ReceivedMessage.Contains("+Key+") == true)
            {
                listBoxInventory.Items.Add("Door Key");
            }
            if (ReceivedMessage.Contains("-Door key-") == true)
            {
                listBoxInventory.Items.Remove("Door Key");
            }
            if (ReceivedMessage.Contains("Congratulations") == true)
            {
                textBoxCommands.Enabled = false;
            }
            return ReceivedMessage;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageGameScreen;
            listBoxGameText.Items.Add("You find yourself in some kind of a room. You soon realize that you are trapped.");
            listBoxGameText.Items.Add("(Beginer tip: you can type 'Examine room' to get a better look at your surroundings.)");
            client = new TcpClient("localhost", 8000);
            Console.WriteLine("Connected to server.");
            if(textBoxCommands.Enabled == false) textBoxCommands.Enabled = true;
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close the game?", "Quit game", 
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

            if (dialogResult == DialogResult.No)
            {

            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit to main menu?", "Exit to main menu", 
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                tabControl1.SelectedTab = tabPageStartScreen;
                listBoxInventory.Items.Clear();
                listBoxGameText.Items.Clear();
                textBoxCommands.Text = null;
                client.Close();
                if (textBoxCommands.Enabled == false) textBoxCommands.Enabled = true;
            }

            if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            labelInventoryList.Visible = true;
            listBoxInventory.Visible = true;
            buttonInventory.Visible = false;
            buttonCloseInventory.Visible = true;
        }

        private void buttonCloseInventory_Click(object sender, EventArgs e)
        {
            labelInventoryList.Visible = false;
            listBoxInventory.Visible = false;
            buttonInventory.Visible = true;
            buttonCloseInventory.Visible = false;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to restart the game?", "Restart game", 
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                stream = client.GetStream();
                stream.Write(prepareForTransmission("restart"), 0, prepareForTransmission("restart").Length);
                Console.WriteLine("Sent message: restart");

                listBoxInventory.Text = null;
                listBoxGameText.Items.Clear();
                textBoxCommands.Text = null;
                if (textBoxCommands.Enabled == false) textBoxCommands.Enabled = true;
                listBoxInventory.Items.Clear();
                listBoxGameText.Items.Add("You find yourself in some kind of a room. You soon realize that you are trapped.");
                listBoxGameText.Items.Add("(Beginer tip: you can type 'Examine room' to get a better look at your surroundings.)");
            }

            if (dialogResult == DialogResult.No)
            {

            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if(textBoxCommands.Text == null)
            {
                command = "empty.";
            }
            else command = textBoxCommands.Text;

            listBoxGameText.Items.Add(">>" + command);
            stream = client.GetStream();
            stream.Write(prepareForTransmission(command), 0, prepareForTransmission(command).Length);
            Console.WriteLine("Sent message: " + command);
            textBoxCommands.Text = null;

            listBoxGameText.Items.Add(prepareForReceiving());
        }

        private void textBoxCommands_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {   
                if(textBoxCommands.Text == null)
                {
                    DialogResult dialogResult = MessageBox.Show("Unable to send empty message!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                buttonSend_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}