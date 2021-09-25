using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using ViewModel;

namespace DataModel
{
    /// <summary>
    /// Base entity of journal pages
    /// </summary>
    public abstract class BaseJournalPageEntity
    {
        /// <summary>
        /// Id of the page - just for internal purposes
        /// </summary>
        [Key]
        public int PageId { get; protected set; }

        // <summary>
        /// Gets the creation date of the journal page
        /// </summary>
        public DateTime CreateAt { get; protected set; }

        /// <summary>
        /// Gets the modification date of the journal page
        /// </summary>
        public DateTime ModifiedAt { get; protected set; }

        /// <summary>
        /// Title of the page
        /// </summary>
        public string Title { get; protected set; }

        /// <summary>
        /// Default constructor - only setting creation date
        /// </summary>
        public BaseJournalPageEntity()
        {
            CreateAt = DateTime.Now;
            Title = CreateAt.ToString("D", CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Gets the view for the current journal page entity
        /// </summary>
        /// <returns></returns>
        public abstract BaseJournalPageViewModel GetView();
    }
}
