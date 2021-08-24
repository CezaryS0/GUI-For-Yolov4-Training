using System.IO;

namespace TrainYolov4
{
    public class Convolutional
    {
        public string size;
        public string stride;
        public string pad;
        public string filters;
        public string activation;
        public void ReadConvolutional(StreamReader stringReader, string s)
        {
            size = s;
            stride = stringReader.ReadLine();
            pad = stringReader.ReadLine();
            filters = stringReader.ReadLine();
            activation = stringReader.ReadLine();
        }
        private string CalcFilters(string filters, int yolo_filters)
        {
            var buf = filters.Split('=');
            var newFilters = buf[0] + '=' + yolo_filters.ToString();
            return newFilters;
        }
        public void FlushLastConvolutional(StreamWriter streamWriter, int yolo_filters)
        {
            streamWriter.WriteLine(size);
            streamWriter.WriteLine(stride);
            streamWriter.WriteLine(pad);
            streamWriter.WriteLine(CalcFilters(filters, yolo_filters));
            streamWriter.WriteLine(activation);
        }
    }
}
