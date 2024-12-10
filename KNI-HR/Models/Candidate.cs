namespace KNI_HR.Models;

public class Candidate
{
    private readonly User user;
    public List<string> CvUrl { get; set; }
    public string? CoveringLetterUrl { get; set; }
    public string? PortfolioUrl { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Education { get; set; }
}
