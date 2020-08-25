using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LearnTabbedPage
{
	public partial class TabbedPageWithDataTemplate : TabbedPage
	{
		public TabbedPageWithDataTemplate()
		{
			InitializeComponent();


			List<MyPage> pages = new List<MyPage>() {
				new MyPage(){ DisplayName="I am page 1", DisplayTitle="首頁", IconName="home.png"},
						new MyPage(){ DisplayName="I am page 2", DisplayTitle="新增會員", IconName="friend.png"},
						//new MyPage(){ DisplayName="I am page 3", DisplayTitle="Page 3", IconName="ic_accessibillity.png"},
						//new MyPage(){ DisplayName="I am page 4", DisplayTitle="Page 4", IconName="ic_accessibillity.png"},


			};

			ItemsSource = pages;

		}
	}





	public class MyPage
	{

		public string DisplayName
		{
			get;
			set;
		}
		public string IconName
		{
			get;
			set;
		}
		public string DisplayTitle
		{
			get;
			set;
		}
	}
}
