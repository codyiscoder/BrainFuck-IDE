using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BrainFuckIDE
{
    public partial class Main : Form
    {
        private int[] memory = new int[30000];
        private int pointer = 0;
        private List<char> output = new List<char>();
        private string input = "";
        private int inputIndex = 0;

        public Main()
        {
            InitializeComponent();
            codeEditor.Text = "++++++++[>++++[>++>+++>+++>+<<<<-]>+>+>->>+[<]<-]>>.>---.+++++++..+++.>>.<-.<.+++.------.--------.>>+.>++.";
            codeEditor.TextChanged += CodeEditor_TextChanged;
            RunBrainfuck();
        }

        private void CodeEditor_TextChanged(object sender, EventArgs e)
        {
            RunBrainfuck();
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            RunBrainfuck();
        }

        private void RunBrainfuck()
        {
            string code = codeEditor.Text;
            if (!IsBalanced(code))
                outputBox.Text = "Syntax Error: Unmatched brackets";

            try
            {
                output.Clear();
                pointer = 0;
                inputIndex = 0;
                memory = new int[30000];
                Execute(code);
                outputBox.Text = new string(output.ToArray());
            }
            catch (Exception ex)
            {
                outputBox.Text = "Runtime Error: " + ex.Message;
            }
        }

        private void Execute(string code)
        {
            for (int i = 0; i < code.Length; i++)
            {
                char cmd = code[i];
                switch (cmd)
                {
                    case '>': pointer++; break;
                    case '<': pointer--; break;
                    case '+': memory[pointer]++; break;
                    case '-': memory[pointer]--; break;
                    case '.': output.Add((char)memory[pointer]); break;
                    case ',':
                        if (inputIndex < input.Length)
                            memory[pointer] = input[inputIndex++];
                        else
                            memory[pointer] = 0;
                        break;
                    case '[':
                        if (memory[pointer] == 0)
                        {
                            int loop = 1;
                            while (loop > 0)
                            {
                                i++;
                                if (i >= code.Length) return;
                                if (code[i] == '[') loop++;
                                else if (code[i] == ']') loop--;
                            }
                        }
                        break;
                    case ']':
                        if (memory[pointer] != 0)
                        {
                            int loop = 1;
                            while (loop > 0)
                            {
                                i--;
                                if (i < 0) return;
                                if (code[i] == ']') loop++;
                                else if (code[i] == '[') loop--;
                            }
                        }
                        break;
                }
            }
        }

        private bool IsBalanced(string code)
        {
            int balance = 0;
            foreach (char c in code)
            {
                if (c == '[') balance++;
                if (c == ']') balance--;
                if (balance < 0) return false;
            }
            return balance == 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}