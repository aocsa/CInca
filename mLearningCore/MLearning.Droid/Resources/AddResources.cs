using System;
using System.Collections.Generic;

namespace MLearning.Droid
{
	public class AddResources
	{

		public List<String> addList = new List<String>(); 

		public List<String> bannerList = new List<String>(); 

		public AddResources ()
		{

 


			addList.Add ("images/ad1.jpg");
			addList.Add ("images/ad2.jpg"); 
			addList.Add ("images/ad3.jpg"); 
			addList.Add ("images/ad4.jpg"); 
			addList.Add ("images/ad5.jpg");
			addList.Add ("images/ad6.jpg"); 
			addList.Add ("images/ad7.jpg"); 
			addList.Add ("images/ad8.jpg"); 

			bannerList.Add ("https://dl.dropboxusercontent.com/u/8925441/banners/banner-01.png");
			bannerList.Add ("https://dl.dropboxusercontent.com/u/8925441/banners/banner-02.png");
			bannerList.Add ("https://dl.dropboxusercontent.com/u/8925441/banners/banner-03.png");


			//ImageView imgProfile = new ImageView (context);

			//Picasso.With(context).Load(item.im_profile).Resize(Configuration.getWidth(45),Configuration.getWidth(45)).CenterCrop().Into(imgProfile);


		}

		private static AddResources instance;


		public static AddResources Instance
		{
			get 
			{
				if (instance == null)
				{
					instance = new AddResources();
				}
				return instance;
			}
		}

	}
}

