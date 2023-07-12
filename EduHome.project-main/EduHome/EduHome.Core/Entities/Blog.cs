using EduHome.Core.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace EduHome.Core.Entities;

public class Blog : IEntity
{
    public int Id { get; set; }
    public string Creator { get; set; } = null!;
    public string date { get; set; } = null!;
    [Required,MaxLength(50)]
    public string Description { get; set; } = null!;
    public string ImagePath { get; set; } = null!;
}
