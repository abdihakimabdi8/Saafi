using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using UIKit;

namespace Saafi.iOS
{
    public class StoryBoardContainer: MvxIosViewsContainer
    {
        public override IMvxIosView CreateViewOfType(Type viewType, MvxViewModelRequest request)
        {
            return (IMvxIosView)UIStoryboard.FromName("Storyboard", null)
                 .InstantiateViewController(viewType.Name);
        }
    }
}