using System;
using System.Linq;

namespace Custom
{
    /// <summary>
    /// <para>
    /// Used to store the current version of the running application. The string must be in the format of "#.#".
    /// </para>
    /// <example> Example:
    /// <code> Version v = "1.0.3.4"; </code>
    /// </example>
    /// </summary>
    [Serializable]
    public class Version
    {
        #region VARIABLES

        private int[] _revisionNumbers = new int[0];

        #endregion

        #region PROPERTIES

        public bool IsRollback { get; set; }

        #endregion

        #region OPERATORS

        public static implicit operator string(Version version)
        {
            return version.ToString();
        }

        public static implicit operator Version(string str)
        {
            var sub = str.Split('.');

            var revisionNumbers = new int[sub.Length];

            if (sub.Where((t, i) => !int.TryParse(t, out revisionNumbers[i])).Any())
            {
                throw new Exception("The string provided did not meet the requirements.");
            }

            var version = new Version
            {
                _revisionNumbers = revisionNumbers
            };

            return version;
        }

        public static bool operator >(Version v1, Version v2)
        {
            int len = v1._revisionNumbers.Length > v2._revisionNumbers.Length ? v1._revisionNumbers.Length : v2._revisionNumbers.Length;

            for (int i = 0; i < len; i++)
            {
                int n1 = v1._revisionNumbers.Length > i ? v1._revisionNumbers[i] : 0;
                int n2 = v2._revisionNumbers.Length > i ? v2._revisionNumbers[i] : 0;

                if (n1 > n2) return true;
            }

            return false;
        }

        public static bool operator <(Version v1, Version v2)
        {
            int len = v1._revisionNumbers.Length > v2._revisionNumbers.Length ? v1._revisionNumbers.Length : v2._revisionNumbers.Length;

            for (int i = 0; i < len; i++)
            {
                int n1 = v1._revisionNumbers.Length > i ? v1._revisionNumbers[i] : 0;
                int n2 = v2._revisionNumbers.Length > i ? v2._revisionNumbers[i] : 0;

                if (n2 > n1) return true;
            }

            return false;
        }

        #endregion

        #region METHODS

        public override string ToString()
        {
            var str = "";
            foreach (int i in _revisionNumbers)
            {
                if (str != "") str += ".";
                str += i;
            }
            return str;
        }

        #endregion

        #region CONSTRUCTORS

        private Version() { }

        #endregion
    }
}
