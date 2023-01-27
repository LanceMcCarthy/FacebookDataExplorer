using Newtonsoft.Json;

namespace FacebookDataExplorer.Models.Data
{
    /// <summary>
    /// For
    /// face_recognition.json
    /// </summary>
    public class FaceRecognitionRoot
    {
        [JsonProperty("facial_data")]
        public FacialData FacialData { get; set; }
    }
    
    public class FacialData
    {
        [JsonProperty("threshold_green")]
        public double ThresholdGreen { get; set; }

        [JsonProperty("threshold_yellow")]
        public double ThresholdYellow { get; set; }

        [JsonProperty("threshold_red")]
        public double ThresholdRed { get; set; }

        [JsonProperty("example_count")]
        public long ExampleCount { get; set; }

        [JsonProperty("raw_data")]
        public string RawData { get; set; }
    }
}