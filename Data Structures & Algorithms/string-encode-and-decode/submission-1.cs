public class Solution {

    public string Encode(IList<string> strs) {
        string encoded = "";
        foreach(var str in strs){
            encoded += str;
            encoded += "~";
        }

        return encoded;
    }

    public List<string> Decode(string s) {
        List<string> decoded = new List<string>();
        string word = "";
        for(int i = 0 ; i< s.Length ; i++){
            if(s[i] == '~'){
                decoded.Add(word);
                word = "";
            }
            else{
                word += s[i];
            }
        }

        return decoded;
   }
}
