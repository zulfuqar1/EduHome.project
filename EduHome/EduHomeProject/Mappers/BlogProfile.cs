using AutoMapper;
using EduHome.Core.Entities;
using EduHomeProject.UI.Areas.EduHomeAdmin.ViewModels.BlogViewModels;

namespace EduHomeProject.UI.Mappers;

public class BlogProfile:Profile
{
	public BlogProfile()
	{
		CreateMap<BlogPostViewModel, Blog>().ReverseMap();
	}
}
