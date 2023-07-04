using System.ComponentModel.DataAnnotations;

namespace EduHomeProject.UI.Areas.EduHomeAdmin.ViewModels.BlogViewModels;

public class BlogPostViewModel
{
    public string Creator { get; set; } = null!;
    public string date { get; set; } = null!;
    [Required, MaxLength(50)]
    public string Description { get; set; } = null!;

    [Required, MaxLength(250)]
    public string ImagePath { get; set; } = null!;
}
