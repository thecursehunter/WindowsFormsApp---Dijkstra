using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dijkstra
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Point> locations = new Dictionary<string, Point>(); // Dictionary để lưu toạ độ của các địa điểm
        private List<string> vertices = new List<string>(); // Danh sách các đỉnh
        private Dictionary<string, Dictionary<string, double>> adjacencyList = new Dictionary<string, Dictionary<string, double>>(); // Danh sách kề
        public Form1()
        {
            InitializeComponent();
        }

        private void AddLocationButton_Click_Click(object sender, EventArgs e)
        {
            string locationName = locationTextBox.Text;
            int x = Convert.ToInt32(xTextBox.Text);
            int y = Convert.ToInt32(yTextBox.Text);
            Point point = new Point(x, y);

            // Thêm địa điểm và toạ độ vào từ điển
            locations.Add(locationName, point);
            vertices.Add(locationName);

            // Cập nhật ComboBoxes
            startComboBox.Items.Add(locationName);
            endComboBox.Items.Add(locationName);

            // Hiển thị địa điểm lên map (có thể sử dụng một PictureBox để vẽ các địa điểm)
            Graphics g = mapPictureBox.CreateGraphics();
            g.DrawEllipse(Pens.Black, x, y, 5, 5);
            g.DrawString(locationName, Font, Brushes.Black, x + 5, y - 5);
        }

        private void AddEdgeButton_Click_Click(object sender, EventArgs e)
        {
            string start = startComboBox.Text;
            string end = endComboBox.Text;
            double distance = CalculateDistance(locations[start], locations[end]);

            // Thêm cạnh vào danh sách kề
            if (!adjacencyList.ContainsKey(start))
            {
                adjacencyList[start] = new Dictionary<string, double>();
            }
            adjacencyList[start][end] = distance;

            if (!adjacencyList.ContainsKey(end))
            {
                adjacencyList[end] = new Dictionary<string, double>();
            }
            adjacencyList[end][start] = distance;

            // Vẽ cạnh giữa hai đỉnh
            Graphics g = mapPictureBox.CreateGraphics();
            g.DrawLine(Pens.Black, locations[start], locations[end]);
        }

        private double CalculateDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }

        private void FindShortestPathButton_Click_Click(object sender, EventArgs e)
        {
            string start = startComboBox.Text;
            string end = endComboBox.Text;

            // Áp dụng thuật toán Dijkstra để tìm đường đi ngắn nhất
            Dictionary<string, double> distances;
            Dictionary<string, string> shortestPath;
            FindShortestPath(start, end, out distances, out shortestPath);

            // Hiển thị kết quả
            string path = ConstructPath(start, end, shortestPath);
            MessageBox.Show($"Shortest path from {start} to {end}: {path}. Distance: {distances[end]}");
        }

        private void FindShortestPath(string start, string end, out Dictionary<string, double> distances, out Dictionary<string, string> shortestPath)
        {
            distances = new Dictionary<string, double>();
            shortestPath = new Dictionary<string, string>();
            HashSet<string> visited = new HashSet<string>();

            foreach (string vertex in vertices)
            {
                distances[vertex] = double.PositiveInfinity;
            }

            distances[start] = 0;

            while (true)
            {
                string closestVertex = null;
                double shortestDistance = double.PositiveInfinity;

                foreach (var vertex in vertices)
                {
                    if (!visited.Contains(vertex) && distances[vertex] < shortestDistance)
                    {
                        closestVertex = vertex;
                        shortestDistance = distances[vertex];
                    }
                }

                if (closestVertex == null)
                {
                    break;
                }

                visited.Add(closestVertex);

                foreach (var neighbor in adjacencyList[closestVertex])
                {
                    double distance = distances[closestVertex] + neighbor.Value;

                    if (distance < distances[neighbor.Key])
                    {
                        distances[neighbor.Key] = distance;
                        shortestPath[neighbor.Key] = closestVertex; // Update shortest path to neighbor
                    }
                }
            }
        }

        private string ConstructPath(string start, string end, Dictionary<string, string> shortestPath)
        {
            List<string> path = new List<string>();
            string currentVertex = end;
            while (currentVertex != start)
            {
                path.Add(currentVertex);
                currentVertex = shortestPath[currentVertex];
            }
            path.Add(start);
            path.Reverse();
            return string.Join(" -> ", path);
        }

        private void locationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void xTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void yTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mapPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void startComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void endComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
