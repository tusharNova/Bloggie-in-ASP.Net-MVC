namespace Bloggie.Web.Models.Domain
{
	public class Tag
	{
		public string Name { get; set; }
		public string DisplayName { get; set; }

		public ICollection<BlogPost> BlogPosts { get; set; }	
	}
}
