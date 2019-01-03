using System;
using System.Collections.Generic;
namespace New_Estate_Baptist_Church.Models
{
    public class pastor
    {
        public string Name { get; set; }
        public string Position{ get; set; }
        public string Details { get; set; }
        public string Image { get; set; }


    }

    public class Ourpastor
    {
        public List<pastor> GetPastors()
        {
            List<pastor> pastors = new List<pastor>()
            {
                new pastor
                {
                    Name="REV. AMOS ACHI KUNAT", Image="kunat.jpg",
                    Position="Senior Pastor",Details="Born on the 6th of May 1965 in Kakuri-Kaduna South, to Late Mr & Mrs Kunat Achi Katung of Dibyi in Zango Kataf Local Government Area of Kaduna State. \n\nHe received his First School Leaving Certificate in 1978 from L. E. A. Primary School Kakuri, Kaduna (1972-1978), and his General Certificate of Education (GCE O’ Level) in 1985 and 1987 after attending Government Day Secondary School, Kakuri, Kaduna (1980-1985) and Federal College of Education, Katsina (1986-1987). He obtained his first degree in Theology (B. Th) from The Nigerian Theological Seminary, Ogbomosho (1990-1994), and a Bachelor of Arts (B. A.) degree in Religious Studies from the University of Ibadan, 1994, graduating with 2nd class Upper Division. \n\nHe currently holds a Master of Arts (MA) degree in Religious Studies specializing in Christian Theology, from the University of Ibadan (2008). \n\nHe gave his life to Christ on the 8th of December 1978 at Calvary Baptist Church Kakuri, Kaduna and answered the call to Christian Ministry in 1990. \n\nRev. Kunat’s full time Pastoral ministry began on the 1st of July 1994 as Pastor of First Baptist Church Uwani Enugu, Enugu State, where he served until November 3, 1999. From there, he proceeded to Victory Baptist Church Ajah, Lekki, Lagos where he served as the Pastor, from November 1999 to February 28, 2002. Thereafter, he proceeded to New Estate Baptist Church, Surulere, Lagos where he was called to serve as the Pastor and has been serving in that capacity till date.\n\n \n\nHe was ordained into full Gospel Ministry in the same Church on October 5, 1996.\n\nRev. Kunat got married to former Miss Esther Baba Karik on the 26th of June, 1993 at Calvary Baptist Church Kakuri Kaduna. She is a teacher with a Master’s Degree in Education from the University of Lagos, specializing in Educational Administration. She is the current Vice Principal (Administration) of Reagan Memorial Baptist Girls Secondary School Yaba, Lagos. The marriage is blessed with three children – Timothy, Eunice and Tychicus."

                },

                new pastor
                {
                    Name="REV JOEL AKIN DARE", Position="Minister for Worship and Music", Details="Joel Akin Dare was born on the 26th March, 1966 in Kumasi, Ghana to the family of Late Pa.Sunday Olaleye Dare and Mama Sarah Jadesola Atole Dare of Ile Ola, Eleesade, Ogbomosho South Local Government, Oyo State.\n\nHe was brought to Nigeria in 1969 due to the quit order that the then Ghanaian Government issued. He was taken to Mefoworade, Ife which was formerly in Oyo state but now Osun State, where he dwelt with his Aunty, who brought him up. There in Mefoworade, he received his Primary School education from All Saints Anglican Primary School (1972-1980) and his Secondary School training from Baptist Grammar School (1980-1985).\n\nIn February 1987 he went back to Ghana where he gave his life to the Lord Jesus Christ in that same year and was baptized on November 13, 1988. He started learning music under the tutelage of Miss Ama Carolyn Houts, one of the Southern Baptist Missionaries to Ghana in 1988. This he quickly mastered and in 1989 began to work in various capacities in Church and Baptist Associations as Choir Director, Organist, Music Instructor and so on. He answered the call of the Master into the Christian Ministry and proceeded to the Nigeria Baptist Theological Seminary, Ogbomosho, where he received pastoral training.\n\nAfter his graduation from the Seminary he assumed his full time Pastoral Ministry as the Minister for Music & Worship of Newlife Baptist Church, Rumueme, Port Harcourt, on September 1, 2002 and served there until September 2005. From Port Harcourt he came to New Estate Baptist Church, Surulere where he has been serving as Minister for Music & Worship since October 14, 2005 till date. He was ordained into full Gospel Ministry on March 26, 2005.\n\nPastor Dare got married to the one he loves, former Funke Rachel Abiodun on August 16, 1997 at Antioch Baptist Church, Kumasi, Ghana. Their union is blessed with three biological children, Mercy, Grace & Peace."
                    ,Image="RevJoelAkinDare.jpg"
                },
                new pastor
                {
                    Name = "REV SOLOMON ADENIYI AJIBADE", Position="Minister for Education and Youth" , Details="Rev. Solomon Adeniyi Ajibade was born on the 9th August, 1969, the Tin city, Plateau State. His parents are Pa James Alagbe Ajibade (Late) and Mama Anike Ajibade(Late) both indigenes of Ogbomosho North Local Government Area of Oyo State. The family are members of Nasarawa Baptist Church, Jos.\n\nHe attended Gwong Baptist Primary School, Jos from 1977-1982 and Common Wealth College of Commerce for his Secondary Education from 1982-1987. During his Secondary Education he also did Vocational Training in Electronic Maintenance from 1984-1988. He obtained his first degree in Theology (B.Th) from Nigerian Baptist Theological Seminary, Ogbomosho (1996-2000), and a Bachelor of Arts (B.A) degree in Religious studies from University of Ibadan, 2001, graduating with 2nd class Upper Division in both. He currently holds a Masters of Arts in Theological Studies, from the from Nigerian Baptist Theological Seminary, Ogbomosho (2009.\n\nIt was during his Secondary Education that he encountered Christ and was saved in 1988 and was baptized in 1993 at Nasarawa Baptist Church by Rev.A.O.Olaniran. in 1990, he received God’s call into the Gospel Ministry and later in 1996 proceeded to the Nigerian Baptist Theological Seminary, Ogbomosho for ministerial training.\n\nOn December 23rd, 200, Solomon Adeniyi Ajibade got married to former Miss Oluwatoyin Olanike Adigun agraduate of the Federal Polytechnic, Bauchi and University of Lagos. An Accountant by profession and a versatile Business woman. The family is blessed with three lovely children, Rereloluwa Sharon, Oreoluwa Johanna, and Obaloluwa David-Jonathan.\n\n"
                    ,Image="RevsolomonAjibade.jpg"
                },

                new pastor
                {
                    Name="PASTOR ENOCH O. SANGODARE", Position ="Minister for Missions and Outreach" , Details="Pastor Enoch Oyebamiji Sangodare came into this world on the 23rd April 1980. He hails from Oyo town in Oyo state to the family of Pa and Mrs Ezekiel O. Sangodare\n\nHe received his Primary Education Certificate from St. Andrew’s Demonstration Primary School, Oyo (1986-1991) and his secondary School Certificate in 1997 from St. Bernadine’s Grammar School, Oyo (now, St. Bernadine’s Girls Grammar School). He obtained his Bachelor degree in Technology (B.Tech. Mech.Engr) from Ladoke Akintola University of Technology, Ogbomoso in the year 2003.\n\nHe surrendered totally to Christ in 1998 at Anglican Grammar School, Ogbomoso during all night prayer organized by Chapel of Salvation. His heart was pierced with the Word of Life and he responded to the altar call that same night.\n\nEnoch had an opportunity to serve with CALVARY PRODUCTIONS in Katsina during his service year (NYSC). It was during this time that God opened his eyes to the very purpose of his living. He answered his Maker without any delay. He worked briefly as an Engineer in a Press Company and as a classroom teacher (Mathematics, Technical drawing and Introductory Technology)\n\nDue to the call of God upon his life and conviction to work with Baptist denomination, he submitted himself for formal theological training at the Nigerian Baptist Theological Seminary, Ogbomoso where he obtained Master of Divinity (Missiology) in June 2010.\n\nPastor Enoch is a missionary and mission mobilizer by calling. He joined the ministry of New Estate Baptist Church, Surulere, Lagos since July 1st, 2010 to take off the Pastoral leadership of a newly planted church, New Estate Baptist Church, Awka, Anambra State. According to God’s plan, he was called back to NEBC, Surulere in February, 2017 as the Minister for Missions and Outreach.\n\nHe has been to several mission fields within and outside Baptist denomination as a visitor and short-term missionary such as Kamuku Home mission Field, Ilaje/Apoi Home mission field, Bassa Home mission field, Dogofinli, Buruwayi, Ohori (Burkina Faso , International Mission field) of the Nigerian Baptist Convention, Hausa 1 Kwantakwamawa, Bango, Yantuaro (CAPRO missions Fields in Katsina).\n\nHe had served earlier in various capacities such as: BSF President, Programme Coordinator, Prayer Coordinator and Evangelism Coordinator. Pastor Enoch served for a period of 4 years as the chairman of Baptist Pastors’ Fellowship, Anambra State Chapter. Also He is the a Pioneer Adviser for Baptist Corpers’ Fellowship (BCF), Anambra State Chapter.\n\nWhile in seminary, Pastor Enoch Sangodare served in Oke Isoko Baptist Church, Ogbomoso (2007-2008) and Ife Oluwa Baptist Church, Ogbomoso till his graduation in 2010.\n\nPastor Enoch got married to former Miss Abigail Oluwasayo Adetutu and their union was blessed with three Children: Eunice Oyekunmi EbereChukwu, Euodia Oyekemi AmaraChukwu and Epaphroditus Oyekunle UdoChukwu. His family watchword is KNOWING HIM(CHRIST) AND MAKING HIM KNOWN\n\n "
                    ,Image="PastorSangodare.jpg"
                }


            };
            return pastors;
        }
    }
}
