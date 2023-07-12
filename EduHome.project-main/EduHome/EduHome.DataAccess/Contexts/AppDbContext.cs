﻿using EduHome.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EduHome.DataAccess.Contexts;

public class AppDbContext:DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

	public DbSet<Slider> Slider { get; set; } = null!;

    public DbSet<Blog> Blogs { get; set; } = null!;
}
