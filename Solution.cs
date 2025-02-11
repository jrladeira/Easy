public class Solution {
    public bool DetectCapitalUse(string word) {
        if (word.Equals(word.ToUpper()) || word.Substring(1).Equals(word.Substring(1).ToLower()))
            return true;

        return false;
    }
}