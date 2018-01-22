using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace splitJson
{
    class Program
    {

        public class sc
        {
            public string resumekey { get; set; }

            public string address1 { get; set; }

            public string address2 { get; set; }

            public string city { get; set; }

            public string candidate_type { get; set; }

            public string candidate_type_changed_userid { get; set; }
            public string state { get; set; }

            public string country { get; set; }

            public DateTime dateadded { get; set; }

            public DateTime datemodified { get; set; }

            public string degree { get; set; }

            public string email { get; set; }

            public string firstname { get; set; }

            public string gpa { get; set; }
            public string gradyear { get; set; }
            public string homephone { get; set; }

            public string jobtitle { get; set; }

            public string lastname { get; set; }

            public int locale { get; set; }
            public string major { get; set; }

            public string middlename { get; set; }

            public string orgname { get; set; }

            public string otherphone { get; set; }
            public string schoolname { get; set; }

            public string zip { get; set; }

            public string active_flag { get; set; }
            public string securecandidate_flag { get; set; }
            public string candidatestackingfield { get; set; }

            public string cellphone { get; set; }

            public string homepage { get; set; }

            public string faxnumber { get; set; }

            public string bruid { get; set; }


        }

        static void Main(string[] args)
        {
            
        }


        public void split() {

            using (StreamReader file = File.OpenText(@"C:\Users\lianpan\Desktop\DGRP\search_candidate\json\candidates - Copy.json"))
            {
                String line = file.ReadToEnd();
                //String line = "{\"items\":[{\"a\":\"a\"},{\"a\":\"a\"}]}{\"items\":[{\"b\":\"b\"},{\"b\":\"b\"}]}{\"items\":[{\"c\":\"c\"},{\"c\":\"c\"}]}{\"items\":[{\"d\":\"d\"},{\"d\":\"d\"}]}";
                //List<String> list=new List<string>()

                int num = 0;
                int n = 0;
                int m = 0;

                while (true)
                {
                    n = line.IndexOf("{\"items\"", n + 1);

                    String t = String.Empty;
                    if (n == -1)
                    {
                        t = line.Substring(m);
                    }
                    else
                    {
                        t = line.Substring(m, n - m);
                    }





                    //
                    //JObject jObject = JObject.Parse(t);
                    //var root = jObject.First.Children().First();

                    //JArray item = new JArray();
                    //int i = 0;

                    //int count = 0;
                    //for (; i < root.Count(); i++, count++)
                    //{
                    //    item.Add((JObject)root[i]);

                    //    if (count >= 10000 || i + 1 >= root.Count())
                    //    {
                    //        JObject items = new JObject(new JProperty("items", item));
                    //        item = new JArray();
                    //        count = 0;

                    //        string fileName = "candidates_splited_" + num + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".json";
                    //        using (StreamWriter toFile = File.CreateText(@"C:\Users\lianpan\Desktop\DGRP\search_candidate\json\New folder\" + fileName))
                    //        {
                    //            JsonSerializer serializer = new JsonSerializer();
                    //            serializer.Serialize(toFile, items);
                    //        }

                    //    }


                    //}

                    string fileName = "candidates_splited_" + num + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".json";
                    using (StreamWriter toFile = File.CreateText(@"C:\Users\lianpan\Desktop\DGRP\search_candidate\json\New folder\" + fileName))
                    {
                        JObject jObject = JObject.Parse(t);
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(toFile, jObject);

                        //File.WriteAllLines(fileName, new StringBuilder(line).Replace("]}{\"items\":[", ",").Replace(@"\", "").ToString());
                        //}

                        //File.WriteAllText(fileName, line2);
                    }


                    if (n == -1)
                    {
                        break;
                    }
                    else
                    {
                        m = n;
                        num++;
                    }
                }
            }
        }


        public void cut() {
            //if (t > 0)
            //{
            //    //line=line.Replace("]}{\"items\":[", ",").Replace(@"\", "");

            //    //line.Replace(@"\", "");
            //    //;
            //    //var line2 = new StringBuilder(line).Replace("]}{\"items\":[", ",");




            //    //JObject jo = (JObject)JsonConvert.DeserializeObject(line2.ToString());
            //    //line = null;

            //    //var Content = new StringContent(line, Encoding.GetEncoding("UTF-8"), "application/json");

            //    string fileName = @"C:\Users\lianpan\Desktop\DGRP\search_candidate\json\candidates_splited_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".json";

            //    //using (StreamWriter sw = new StreamWriter(fileName))
            //    //{
            //    //    sw.Write(line2.ToString());
            //    //}


            //    //using (StreamWriter toFile = File.CreateText(@"C:\Users\lianpan\Desktop\DGRP\search_candidate\json\" + fileName))
            //    //{
            //    //    JsonSerializer serializer = new JsonSerializer();
            //    //    serializer.Serialize(toFile, line2);

            //    //    //File.WriteAllLines(fileName, new StringBuilder(line).Replace("]}{\"items\":[", ",").Replace(@"\", "").ToString());
            //    //    //}

            //    //    //File.WriteAllText(fileName, line2);
            //    //}

            //}
            //Console.Write(count);



            //    using (StreamReader file = File.OpenText(@"C:\Users\lianpan\Desktop\DGRP\search_candidate\json\New folder\candidates - Copy.json.joined.json"))
            //    {
            //        using (JsonTextReader reader = new JsonTextReader(file))
            //        {
            //            JObject jObject = (JObject)JToken.ReadFrom(reader);

            //            var root = jObject.First.Children().First();

            //            int count = 0;

            //            JArray item = new JArray();
            //            int i = 0;

            //            for (; i < root.Count(); i++, count++)
            //            {
            //                item.Add((JObject)root[i]);

            //                if (count >= 10000 || i + 1 >= root.Count())
            //                {
            //                    JObject items = new JObject(new JProperty("items", item));
            //                    item = new JArray();
            //                    count = 0;

            //                    string fileName = "candidates_splited_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".json";
            //                    using (StreamWriter toFile = File.CreateText(@"C:\Users\lianpan\Desktop\DGRP\search_candidate\json\New folder\" + fileName))
            //                    {
            //                        JsonSerializer serializer = new JsonSerializer();
            //                        serializer.Serialize(toFile, items);
            //                    }

            //                }


            //            }

            //            Console.Write(i);

            //        }



            //    }
            //}
        }
    }
}
