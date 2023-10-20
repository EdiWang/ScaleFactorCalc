using System.ComponentModel.DataAnnotations;

public class DisplayInfo
{
    [Required]
    [Range(800, 10240)]
    public int PixelX { get; set; } = 1920;

    [Required]
    [Range(600, 20480)]
    public int PixelY { get; set; } = 1080;

    [Required]
    [Range(1, 1024)]
    public double Diagonal { get; set; } = 24;
}
