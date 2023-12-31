﻿using EduHome.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EduHome.DataAccess.Contexts;

public class AppDbContext : IdentityDbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

	public DbSet<Slider> Slider { get; set; } = null!;

	public DbSet<Blog> Blogs { get; set; } = null!;

    public DbSet <AppUser> appusers { get; set; } = null!;
}
