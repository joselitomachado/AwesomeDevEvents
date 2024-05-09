namespace AwesomeDevEvents.API.Models;

public class DevEventViewModel
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<DevEventSpeakerViewModel> Speakers { get; set; } = [];
}