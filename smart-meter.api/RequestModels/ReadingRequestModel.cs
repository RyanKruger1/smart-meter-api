namespace smart_meter.api.RequestModels
{
    public class ReadingRequestModel
    {
        public double voltage { get; set; }
        public double current { get; set; }
        public double power { get; set; }
        public double powerFactor { get; set; }
    }
}
