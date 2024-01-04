using Arm64.DesktopApp.WindowsForms.Helpers;

namespace Arm64.DesktopApp.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            labelArchitecture.Text = $"Processor architecture: {Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE")}";

            Text = "ARM";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int matrixSize = Convert.ToInt32(numericUpDownMatrixSize.Value);
            int executionCount = Convert.ToInt32(numericUpDownExecutionCount.Value);
            
            var executionTime = PerformanceHelper.MeasurePerformance(
                () => MatrixHelper.SquareMatrixMultiplication(matrixSize),
                executionCount);

            listBoxResults.Items.Add($"Size: {matrixSize}, Count: {executionCount}, " +
                $"Time: {executionTime} ms");
        }
    }
}
