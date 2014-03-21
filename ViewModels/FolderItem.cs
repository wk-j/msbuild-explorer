﻿//---------------------------------------------------------------------------------------------------------------------------
// <copyright file="FolderItem.cs">(c) Mike Fourie. All other rights reserved.</copyright>
//---------------------------------------------------------------------------------------------------------------------------
// <autogenerated/>
namespace MSBuildExplorer.ViewModels
{
    using System.Collections;
    using MSBuildExplorer.DataModel;

    public class FolderItem : SimpleObject
    {
        #region Name
        private string name;

        /// <summary>
        /// The name that can be displayed or used as an
        /// ID to perform more complex styling.
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                //ignore if values are equal
                if (value == name) return;

                name = value;
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// The name that can be displayed or used as an
        /// ID to perform more complex styling.
        /// </summary>
        private string image;


        /// <summary>
        /// The name that can be displayed or used as an
        /// ID to perform more complex styling.
        /// </summary>
        public string Image
        {
            get { return image; }
            set
            {
                //ignore if values are equal
                if (value == image) return;

                image = value;
                OnPropertyChanged("Image");
            }
        }

        #endregion

        #region Items

        /// <summary>
        /// The child items of the folder.
        /// </summary>
        private IEnumerable items;


        /// <summary>
        /// The child items of the folder.
        /// </summary>
        public IEnumerable Items
        {
            get { return items; }
            set
            {
                //ignore if values are equal
                if (value == items) return;

                items = value;
                OnPropertyChanged("Items");
            }
        }

        #endregion


        public FolderItem()
        {
        }



        /// <summary>
        /// This method is invoked by WPF to render the object if
        /// no data template is available.
        /// </summary>
        /// <returns>Returns the value of the <see cref="Name"/>
        /// property.</returns>
        public override string ToString()
        {
            return string.Format("{0}: {1}", GetType().Name, Name);
        }
    }
}