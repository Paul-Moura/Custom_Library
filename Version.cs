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

        private int[] RevisionNumbers
        {
            get
            {
                var sub = Value.Split('.');

                var revisionNumbers = new int[sub.Length];

                if (sub.Where((t, i) => !int.TryParse(t, out revisionNumbers[i])).Any())
                {
                    throw new Exception("The string provided did not meet the requirements.");
                }

                return revisionNumbers;
            }
        }

        private string _value;

        #endregion

        #region PROPERTIES

        public bool IsRollback { get; set; }

        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (!IsValid(value)) throw new Exception("The string provided did not meet the requirements.");
                _value = value;
            }
        }

        #endregion

        #region OPERATORS

        public static implicit operator string(Version version)
        {
            return version.ToString();
        }

        public static implicit operator Version(string str)
        {
            return new Version { Value = str };
        }

        public static bool operator >(Version v1, Version v2)
        {
            int len = v1.RevisionNumbers.Length > v2.RevisionNumbers.Length ? v1.RevisionNumbers.Length : v2.RevisionNumbers.Length;

            for (int i = 0; i < len; i++)
            {
                int n1 = v1.RevisionNumbers.Length > i ? v1.RevisionNumbers[i] : 0;
                int n2 = v2.RevisionNumbers.Length > i ? v2.RevisionNumbers[i] : 0;

                if (n1 > n2) return true;
            }

            return false;
        }

        public static bool operator <(Version v1, Version v2)
        {
            int len = v1.RevisionNumbers.Length > v2.RevisionNumbers.Length ? v1.RevisionNumbers.Length : v2.RevisionNumbers.Length;

            for (int i = 0; i < len; i++)
            {
                int n1 = v1.RevisionNumbers.Length > i ? v1.RevisionNumbers[i] : 0;
                int n2 = v2.RevisionNumbers.Length > i ? v2.RevisionNumbers[i] : 0;

                if (n2 > n1) return true;
            }

            return false;
        }

        #endregion

        #region METHODS

        public override string ToString()
        {
            return Value;
        }

        public static bool IsValid(string value)
        {
            try
            {
                var s = value.Split('.');
                foreach (string sub in s)
                {
                    int.Parse(sub);
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        #endregion

        #region CONSTRUCTORS

        private Version() { }

        #endregion
    }
}
