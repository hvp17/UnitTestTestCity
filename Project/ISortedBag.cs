namespace Project
{
    public interface ISortedBag
    {
        /// <summary>
        /// add to collection of values
        /// </summary>

        int Add(int id);

        /// <summary>
        /// size of collection
        /// </summary>
        int Count { get; }

        /// <summary>
        /// return and remove smallest value in collection
        /// </summary>

        int Get { get; }

        /// <summary>
        /// returns smallest value in collection
        /// </summary>
       int Peek { get; }
    }
}
