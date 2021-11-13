namespace ViewModel
{
    /// <summary>
    /// Item for page type selection
    /// </summary>
    public class SelectorItems
    {
        /// <summary>
        /// Type of the page
        /// </summary>
        public PageTypes PageType { get; set; }

        /// <summary>
        /// Name of the item
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Icon of the item
        /// </summary>
        //public byte[] Icon { get; set; }

        /// <summary>
        /// Description of the item
        /// </summary>
        public string Description { get; set; }
    }
}
