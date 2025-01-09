namespace DevelopmentPlusAsessement
{
    public class DuplicateChecker<T> where T : IEquatable<T>
    {
        public static string CheckDuplicates(List<T> collectionA, List<T> collectionS)
        {
            HashSet<T> setA = new HashSet<T>(collectionA);

            Dictionary<T, bool> results = new Dictionary<T, bool>();
            var result = "";
            foreach (T element in collectionS)
            {
                result += $"{element}: {setA.Contains(element)}\n";
            }

            return result;
        }
    }
}
