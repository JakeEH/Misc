using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Element
    {

        public List<Element> InnerHTML { get; set; }
        public string TagName { get; set; }

        public Element()
        {
            InnerHTML = new List<Element>();
        }

        public void PrintTags(string tier)
        {
            foreach (var inner in InnerHTML)
            {
                Console.Write(tier);
                Console.WriteLine(inner.TagName);
                if (inner.InnerHTML.Count > 0)
                {
                    tier += "-";
                }
                inner.PrintTags(tier);

            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Element page = new Element();
            Element head = new Element();
            Element body = new Element();
            Element p = new Element();
            Element div = new Element();
            Element divTesting = new Element();

            head.TagName = "Head";       
            body.TagName = "Body";         
            p.TagName = "P";           
            div.TagName = "Div";
            divTesting.TagName = "Div";
            div.InnerHTML.Add(p);
            div.InnerHTML.Add(p);
            div.InnerHTML.Add(divTesting);
            body.InnerHTML.Add(p);
            body.InnerHTML.Add(div);

            page.InnerHTML.Add(head);
            page.InnerHTML.Add(body);
            page.PrintTags(String.Empty);
            Console.ReadLine();

        }

    }

}
