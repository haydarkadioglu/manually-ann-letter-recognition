using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            createButtons();
        }

        

        NeuralNetwork nn = new NeuralNetwork(7*5, 16, 5);


        private int[,] inputSet = new int[7, 5]{
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 }
        };

        private int[,] desiredOutput = new int[,] {
                    {0,0,0,0,1},
                    {0,0,0,1,0},
                    {0,0,1,0,0},
                    {0,1,0,0,0},
                    {1,0,0,0,0}
        };



        private void Buttons_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int[] indexes = (int[])clickedButton.Tag; 

            int rowIndex = indexes[0];
            int colIndex = indexes[1];

            if (inputSet[rowIndex, colIndex] == 0)
            {
                inputSet[rowIndex, colIndex] = 1;
                clickedButton.BackColor = Color.Black;
            }
            else
            {
                inputSet[rowIndex, colIndex] = 0;
                clickedButton.BackColor = Color.White;
            }
        }

        private void createButtons()
        {
            int buttonWidth = 25;
            int buttonHeight = 25;
            int groupBoxWidth = groupBox1.Width;
            int groupBoxHeight = groupBox1.Height;
            int numRows = 7;
            int numCols = 5;
            int spacingX = (groupBoxWidth - buttonWidth * numCols) / (numCols + 1);
            int spacingY = (groupBoxHeight - buttonHeight * numRows) / (numRows + 1);

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(buttonWidth, buttonHeight);
                    int x = (j + 1) * spacingX + j * buttonWidth;
                    int y = (i + 1) * spacingY + i * buttonHeight;
                    button.Location = new Point(x, y);
                    button.Click += Buttons_Click;
                    button.Tag = new int[] { i, j }; 
                    groupBox1.Controls.Add(button); 
                }
            }
        }

        private void button_predict_Click(object sender, EventArgs e)
        {
            float[] prediction = nn.Predict(inputSet);

            label_resA.Text = prediction[4].ToString();
            label_resB.Text = prediction[3].ToString();
            label_resC.Text = prediction[2].ToString();
            label_resD.Text = prediction[1].ToString();
            label_resE.Text = prediction[0].ToString();
            

            
        }


        

        private void button_train_Click(object sender, EventArgs e)
        {


            nn.Train(trainingSet, desiredOutput, learningRate: 0.1f, epochs: int.Parse(textBox_epoch.Text));
            nn.Train(trainingSet2, desiredOutput, learningRate: 0.1f, epochs: int.Parse(textBox_epoch.Text));
            nn.Train(trainingSet3, desiredOutput, learningRate: 0.1f, epochs: int.Parse(textBox_epoch.Text));


            MessageBox.Show("Train complated...");
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.BackColor = Color.White;
                }
            }
            inputSet = new int[7, 5]{
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 }
            };

            label_resA.Text = "";
            label_resB.Text = "";
            label_resC.Text = "";
            label_resD.Text = "";
            label_resE.Text = "";


        }
        private int[,,] trainingSet = new int[5, 7, 5] {
                    { {0,0,1,0,0},
                    {0,1,0,1,0},
                    {1,0,0,0,1},
            /* A */ {1,0,0,0,1},
                    {1,1,1,1,1},
                    {1,0,0,0,1},
                    {1,0,0,0,1} },

                    { {1,1,1,1,0},
                    {1,0,0,0,1},
                    {1,0,0,0,1},
            /* B */ {1,1,1,1,0},
                    {1,0,0,0,1},
                    {1,0,0,0,1},
                    {1,1,1,1,0} },

                    { {0,0,1,1,1},
                    {0,1,0,0,0},
                    {1,0,0,0,0},
            /* C */ {1,0,0,0,0},
                    {1,0,0,0,0},
                    {0,1,0,0,0},
                    {0,0,1,1,1} },

                    { {1,1,1,0,0},
                    {1,0,0,1,0},
                    {1,0,0,0,1},
                    {1,0,0,0,1},
            /* D */ {1,0,0,0,1},
                    {1,0,0,1,0},
                    {1,1,1,0,0} },

                    { {1,1,1,1,1},
                    {1,0,0,0,0},
                    {1,0,0,0,0},
                    {1,1,1,1,1},
            /* E */ {1,0,0,0,0},
                    {1,0,0,0,0},
                    {1,1,1,1,1} }
        };


        private int[,,] trainingSet2 = new int[5, 7, 5] {
                    { {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,1,1,0},
            /* A */ {0,1,0,0,1},
                    {0,1,1,1,1},
                    {0,1,0,0,1},
                    {0,1,0,0,1} },

                    { {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,1,1,1,0},
            /* B */ {0,1,0,0,1},
                    {0,1,1,1,1},
                    {0,1,0,0,1},
                    {0,1,1,1,0} },

                    { {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,1,1,1},
            /* C */ {0,1,0,0,0},
                    {0,1,0,0,0},
                    {0,0,1,1,1},
                    {0,0,0,0,0} },

                    { {0,0,0,0,0},
                    {0,1,1,1,0},
                    {0,1,0,0,1},
                    {0,1,0,0,1},
            /* D */ {0,1,0,0,1},
                    {0,1,1,1,0},
                    {0,0,0,0,0} },

                    { {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,1,1,1,1},
                    {0,1,0,0,0},
            /* E */ {0,1,1,1,1},
                    {0,1,0,0,0},
                    {0,1,1,1,1} }
        };

        private int[,,] trainingSet3 = new int[5, 7, 5] {
                    { {0,0,1,0,0},
                    {0,1,0,1,0},
                    {0,1,1,1,0},
            /* A */ {0,1,0,1,0},
                    {0,1,0,1,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0} },

                    { {0,1,1,1,0},
                    {0,1,0,0,1},
                    {0,1,0,0,1},
            /* B */ {0,1,1,1,1},
                    {0,1,0,0,1},
                    {0,1,1,1,0},
                    {0,0,0,0,0} },

                    { {0,0,0,0,0},
                    {0,0,1,1,1},
                    {0,1,0,0,0},
            /* C */ {1,0,0,0,0},
                    {0,1,1,1,1},
                    {0,0,0,0,0},
                    {0,0,0,0,0} },

                    { {0,0,0,0,0},
                    {0,0,0,0,0},
                    {1,1,1,1,0},
                    {1,0,0,0,1},
            /* D */ {1,0,0,0,1},
                    {1,0,0,0,1},
                    {1,1,1,1,0} },

                    { {0,0,0,0,0},
                    {1,1,1,1,1},
                    {1,0,0,0,0},
                    {1,1,1,0,0},
            /* E */ {1,1,1,0,0},
                    {1,0,0,0,0},
                    {1,1,1,1,1} }
        };

    }
}

public class NeuralNetwork
{
    private int inputLayerSize;
    private int hiddenLayerSize;
    private int outputLayerSize;
    private float[][] neurons;
    private float[][][] weights;

    public NeuralNetwork(int inputLayerSize, int hiddenLayerSize, int outputLayerSize)
    {
        this.inputLayerSize = inputLayerSize;
        this.hiddenLayerSize = hiddenLayerSize;
        this.outputLayerSize = outputLayerSize;

        InitNeurons();
        InitWeights();
    }

    private void InitNeurons()
    {
        neurons = new float[3][]; 
        neurons[0] = new float[inputLayerSize];
        neurons[1] = new float[hiddenLayerSize];
        neurons[2] = new float[outputLayerSize];
    }

    private void InitWeights()
    {
        weights = new float[2][][]; 
        weights[0] = new float[hiddenLayerSize][];
        weights[1] = new float[outputLayerSize][];

        Random rnd = new Random();
        for (int i = 0; i < hiddenLayerSize; i++)
        {
            weights[0][i] = new float[inputLayerSize];
            for (int j = 0; j < inputLayerSize; j++)
            {
                weights[0][i][j] = (float)rnd.NextDouble() * 2 - 1; 
            }
        }

        for (int i = 0; i < outputLayerSize; i++)
        {
            weights[1][i] = new float[hiddenLayerSize];
            for (int j = 0; j < hiddenLayerSize; j++)
            {
                weights[1][i][j] = (float)rnd.NextDouble() * 2 - 1; 
            }
        }
    }

    public float[] FeedForward(int[] inputs)
    {
        
        for (int i = 0; i < inputLayerSize; i++)
        {
            neurons[0][i] = inputs[i];
        }

        
        for (int i = 0; i < hiddenLayerSize; i++)
        {
            float sum = 0;
            for (int j = 0; j < inputLayerSize; j++)
            {
                sum += neurons[0][j] * weights[0][i][j];
            }
            neurons[1][i] = Math.Max(0, sum); 
        }

        for (int i = 0; i < outputLayerSize; i++)
        {
            float sum = 0;
            for (int j = 0; j < hiddenLayerSize; j++)
            {
                sum += neurons[1][j] * weights[1][i][j];
            }
            neurons[2][i] = (float)Math.Tanh(sum); 
        }

        return neurons[2]; 
    }

    public void Train(int[,,] trainingSet, int[,] trainingLabels, float learningRate, int epochs)
    {
        int numSamples = trainingSet.GetLength(0);
        float totalError = 0;
        for (int epoch = 0; epoch < epochs; epoch++)
        {


            for (int i = 0; i < numSamples; i++)
            {
                
                int[] input = Flatten(trainingSet, i);

                float[] predictedOutput = FeedForward(input);

                float[] targetOutput = GetTargetOutput(trainingLabels, i);
                float error = CalculateError(predictedOutput, targetOutput);
                totalError += error;

                
                Backpropagate(targetOutput, learningRate);
            }

            float meanError = totalError / numSamples;
        }
        MessageBox.Show($"{epochs}, Mean Error: {totalError}");
    }

    
    private float[] GetTargetOutput(int[,] trainingLabels, int index)
    {
        int outputSize = trainingLabels.GetLength(1);
        float[] targetOutput = new float[outputSize];
        for (int j = 0; j < outputSize; j++)
        {
            targetOutput[j] = trainingLabels[index, j];
        }
        return targetOutput;
    }


    
    private int[] Flatten(int[,,] trainingSet, int index)
    {
        int size = trainingSet.GetLength(1) * trainingSet.GetLength(2);
        int[] input = new int[size];
        for (int i = 0; i < trainingSet.GetLength(1); i++)
        {
            for (int j = 0; j < trainingSet.GetLength(2); j++)
            {
                input[i * trainingSet.GetLength(2) + j] = trainingSet[index, i, j];
            }
        }
        return input;
    }
    
    private float CalculateError(float[] predicted, float[] target)
    {
        float sum = 0;
        for (int i = 0; i < predicted.Length; i++)
        {
            sum += (predicted[i] - target[i]) * (predicted[i] - target[i]);
        }
        return sum / 2; 
    }

    private void Backpropagate(float[] targetOutput, float learningRate)
    {
        
        float[] outputDeltas = new float[outputLayerSize];
        for (int i = 0; i < outputLayerSize; i++)
        {
            outputDeltas[i] = (neurons[2][i] - targetOutput[i]) * (1 - neurons[2][i] * neurons[2][i]);
        }

        
        for (int i = 0; i < outputLayerSize; i++)
        {
            for (int j = 0; j < hiddenLayerSize; j++)
            {
                weights[1][i][j] -= learningRate * outputDeltas[i] * neurons[1][j];
            }
        }

        
        float[] hiddenDeltas = new float[hiddenLayerSize];
        for (int i = 0; i < hiddenLayerSize; i++)
        {
            float sum = 0;
            for (int j = 0; j < outputLayerSize; j++)
            {
                sum += outputDeltas[j] * weights[1][j][i];
            }
            hiddenDeltas[i] = sum * (1 - neurons[1][i] * neurons[1][i]);
        }

        
        for (int i = 0; i < hiddenLayerSize; i++)
        {
            for (int j = 0; j < inputLayerSize; j++)
            {
                weights[0][i][j] -= learningRate * hiddenDeltas[i] * neurons[0][j];
            }
        }
    }

    public float[] Predict(int[,] input)
    {
        int[] flattenedInput = Flatten2(input);
        return FeedForward(flattenedInput);
    }

    
    private int[] Flatten2(int[,] input)
    {
        int size = input.GetLength(0) * input.GetLength(1);
        int[] flattenedInput = new int[size];
        for (int i = 0; i < input.GetLength(0); i++)
        {
            for (int j = 0; j < input.GetLength(1); j++)
            {
                flattenedInput[i * input.GetLength(1) + j] = input[i, j];
            }
        }
        return flattenedInput;
    }

}