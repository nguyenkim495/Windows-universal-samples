﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASBMigrationSample
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }
        public string Company { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1})", FullName, Company);
        }
    }

    public static class ContactSampleDataSource
    {
        private static List<Contact> _contacts = new List<Contact>()
        {
            new Contact(){FirstName="James", LastName="Buchanan", Company="Benton"},
            new Contact(){FirstName="Josephine", LastName="Darakjy", Company="Chanay"},
            new Contact(){FirstName="Art", LastName="Venere", Company="Chemel"},
            new Contact(){FirstName="Lenna", LastName="Paprocki", Company="Feltz Printing Service"},
            new Contact(){FirstName="Donette", LastName="Foller", Company="Printing Dimensions"},
            new Contact(){FirstName="Simona", LastName="Morasca", Company="Chapman"},
            new Contact(){FirstName="Mitsue", LastName="Tollner", Company="Morlong Associates"},
            new Contact(){FirstName="Leota", LastName="Dilliard", Company="Commercial Press"},
            new Contact(){FirstName="Sage", LastName="Wieser", Company="Truhlar And Truhlar Attys"},
            new Contact(){FirstName="Kris", LastName="Marrier", Company="King"},
            new Contact(){FirstName="Minna", LastName="Amigon", Company="Dorl"},
            new Contact(){FirstName="Abel", LastName="Maclead", Company="Rangoni Of Florence"},
            new Contact(){FirstName="Kiley", LastName="Caldarera", Company="Feiner Bros"},
            new Contact(){FirstName="Graciela", LastName="Ruta", Company="Buckley Miller & Wright"},
            new Contact(){FirstName="Cammy", LastName="Albares", Company="Rousseaux"},
            new Contact(){FirstName="Mattie", LastName="Poquette", Company="Century Communications"},
            new Contact(){FirstName="Meaghan", LastName="Garufi", Company="Bolton"},
            new Contact(){FirstName="Gladys", LastName="Rim", Company="T M Byxbee Company Pc"},
            new Contact(){FirstName="Yuki", LastName="Whobrey", Company="Farmers Insurance Group"},
            new Contact(){FirstName="Fletcher", LastName="Flosi", Company="Post Box Services Plus"},
            new Contact(){FirstName="Bette", LastName="Nicka", Company="Sport En Art"},
            new Contact(){FirstName="Veronika", LastName="Inouye", Company="C 4 Network Inc"},
            new Contact(){FirstName="Willard", LastName="Kolmetz", Company="Ingalls"},
            new Contact(){FirstName="Maryann", LastName="Royster", Company="Franklin"},
            new Contact(){FirstName="Alisha", LastName="Slusarski", Company="Wtlz Power 107 Fm"},
            new Contact(){FirstName="Allene", LastName="Iturbide", Company="Ledecky"},
            new Contact(){FirstName="Chanel", LastName="Caudy", Company="Professional Image Inc"},
            new Contact(){FirstName="Ezekiel", LastName="Chui", Company="Sider"},
            new Contact(){FirstName="Willow", LastName="Kusko", Company="U Pull It"},
            new Contact(){FirstName="Bernardo", LastName="Figeroa", Company="Clark"},
            new Contact(){FirstName="Ammie", LastName="Corrio", Company="Moskowitz"},
            new Contact(){FirstName="Francine", LastName="Vocelka", Company="Cascade Realty Advisors Inc"},
            new Contact(){FirstName="Ernie", LastName="Stenseth", Company="Knwz Newsradio"},
            new Contact(){FirstName="Albina", LastName="Glick", Company="Giampetro"},
            new Contact(){FirstName="Alishia", LastName="Sergi", Company="Milford Enterprises Inc"},
            new Contact(){FirstName="Solange", LastName="Shinko", Company="Mosocco"},
            new Contact(){FirstName="Jose", LastName="Stockham", Company="Tri State Refueler Co"},
            new Contact(){FirstName="Rozella", LastName="Ostrosky", Company="Parkway Company"},
            new Contact(){FirstName="Valentine", LastName="Gillian", Company="Fbs Business Finance"},
            new Contact(){FirstName="Kati", LastName="Rulapaugh", Company="Eder Assocs Consltng Engrs Pc"},
            new Contact(){FirstName="Youlanda", LastName="Schemmer", Company="Tri M Tool Inc"},
            new Contact(){FirstName="Dyan", LastName="Oldroyd", Company="International Eyelets Inc"},
            new Contact(){FirstName="Roxane", LastName="Campain", Company="Rapid Trading Intl"},
            new Contact(){FirstName="Lavera", LastName="Perin", Company="Abc Enterprises Inc"},
            new Contact(){FirstName="Erick", LastName="Ferencz", Company="Cindy Turner Associates"},
            new Contact(){FirstName="Fatima", LastName="Saylors", Company="Stanton"},
            new Contact(){FirstName="Jina", LastName="Briddick", Company="Grace Pastries Inc"},
            new Contact(){FirstName="Kanisha", LastName="Waycott", Company="Schroer"},
            new Contact(){FirstName="Emerson", LastName="Bowley", Company="Knights Inn"},
            new Contact(){FirstName="Blair", LastName="Malet", Company="Bollinger Mach Shp & Shipyard"},
            new Contact(){FirstName="Brock", LastName="Bolognia", Company="Orinda News"},
            new Contact(){FirstName="Lorrie", LastName="Nestle", Company="Ballard Spahr Andrews"},
            new Contact(){FirstName="Sabra", LastName="Uyetake", Company="Lowy Limousine Service"},
            new Contact(){FirstName="Marjory", LastName="Mastella", Company="Vicon Corporation"},
            new Contact(){FirstName="Karl", LastName="Klonowski", Company="Rossi"},
            new Contact(){FirstName="Tonette", LastName="Wenner", Company="Northwest Publishing"},
            new Contact(){FirstName="Amber", LastName="Monarrez", Company="Branford Wire & Mfg Co"},
            new Contact(){FirstName="Shenika", LastName="Seewald", Company="East Coast Marketing"},
            new Contact(){FirstName="Delmy", LastName="Ahle", Company="Wye Technologies Inc"},
            new Contact(){FirstName="Deeanna", LastName="Juhas", Company="Healy"},
            new Contact(){FirstName="Blondell", LastName="Pugh", Company="Alpenlite Inc"},
            new Contact(){FirstName="Jamal", LastName="Vanausdal", Company="Hubbard"},
            new Contact(){FirstName="Cecily", LastName="Hollack", Company="Arthur A Oliver & Son Inc"},
            new Contact(){FirstName="Carmelina", LastName="Lindall", Company="George Jessop Carter Jewelers"},
            new Contact(){FirstName="Maurine", LastName="Yglesias", Company="Schultz"},
            new Contact(){FirstName="Tawna", LastName="Buvens", Company="H H H Enterprises Inc"},
            new Contact(){FirstName="Penney", LastName="Weight", Company="Hawaiian King Hotel"},
            new Contact(){FirstName="Elly", LastName="Morocco", Company="Killion Industries"},
            new Contact(){FirstName="Ilene", LastName="Eroman", Company="Robinson"},
            new Contact(){FirstName="Vallie", LastName="Mondella", Company="Private Properties"},
            new Contact(){FirstName="Kallie", LastName="Blackwood", Company="Rowley Schlimgen Inc"},
            new Contact(){FirstName="Johnetta", LastName="Abdallah", Company="Forging Specialties"},
            new Contact(){FirstName="Bobbye", LastName="Rhym", Company="Smits"},
            new Contact(){FirstName="Micaela", LastName="Rhymes", Company="H Lee Leonard Attorney At Law"},
            new Contact(){FirstName="Tamar", LastName="Hoogland", Company="A K Construction Co"},
            new Contact(){FirstName="Moon", LastName="Parlato", Company="Ambelang"},
            new Contact(){FirstName="Laurel", LastName="Reitler", Company="Q A Service"},
            new Contact(){FirstName="Delisa", LastName="Crupi", Company="Wood & Whitacre Contractors"},
            new Contact(){FirstName="Viva", LastName="Toelkes", Company="Mark Iv Press Ltd"},
            new Contact(){FirstName="Elza", LastName="Lipke", Company="Museum Of Science & Industry"},
            new Contact(){FirstName="Devorah", LastName="Chickering", Company="Garrison Ind"},
            new Contact(){FirstName="Timothy", LastName="Mulqueen", Company="Saronix Nymph Products"},
            new Contact(){FirstName="Arlette", LastName="Honeywell", Company="Smc Inc"},
            new Contact(){FirstName="Dominque", LastName="Dickerson", Company="E A I Electronic Assocs Inc"},
            new Contact(){FirstName="Lettie", LastName="Isenhower", Company="Conte"},
            new Contact(){FirstName="Myra", LastName="Munns", Company="Anker Law Office"},
            new Contact(){FirstName="Stephaine", LastName="Barfield", Company="Beutelschies & Company"},
            new Contact(){FirstName="Lai", LastName="Gato", Company="Fligg"},
            new Contact(){FirstName="Stephen", LastName="Emigh", Company="Sharp"},
            new Contact(){FirstName="Tyra", LastName="Shields", Company="Assink"},
            new Contact(){FirstName="Tammara", LastName="Wardrip", Company="Jewel My Shop Inc"},
            new Contact(){FirstName="Cory", LastName="Gibes", Company="Chinese Translation Resources"},
            new Contact(){FirstName="Danica", LastName="Bruschke", Company="Stevens"},
            new Contact(){FirstName="Wilda", LastName="Giguere", Company="Mclaughlin"},
            new Contact(){FirstName="Elvera", LastName="Benimadho", Company="Tree Musketeers"},
            new Contact(){FirstName="Carma", LastName="Vanheusen", Company="Springfield Div Oh Edison Co"},
            new Contact(){FirstName="Malinda", LastName="Hochard", Company="Logan Memorial Hospital"},
            new Contact(){FirstName="Natalie", LastName="Fern", Company="Kelly"},
            new Contact(){FirstName="Lisha", LastName="Centini", Company="Industrial Paper Shredders Inc"},
            new Contact(){FirstName="Arlene", LastName="Klusman", Company="Beck Horizon Builders"},
            new Contact(){FirstName="Alease", LastName="Buemi", Company="Porto Cayo At Hawks Cay"},
            new Contact(){FirstName="Louisa", LastName="Cronauer", Company="Pacific Grove Museum Ntrl Hist"},
            new Contact(){FirstName="Angella", LastName="Cetta", Company="Bender & Hatley Pc"},
            new Contact(){FirstName="Cyndy", LastName="Goldammer", Company="Di Cristina J & Son"},
            new Contact(){FirstName="Rosio", LastName="Cork", Company="Green Goddess"},
            new Contact(){FirstName="Celeste", LastName="Korando", Company="American Arts & Graphics"},
            new Contact(){FirstName="Twana", LastName="Felger", Company="Opryland Hotel"},
            new Contact(){FirstName="Estrella", LastName="Samu", Company="Marking Devices Pubg Co"},
            new Contact(){FirstName="Donte", LastName="Kines", Company="W Tc Industries Inc"},
            new Contact(){FirstName="Tiffiny", LastName="Steffensmeier", Company="Whitehall Robbins Labs Divsn"},
            new Contact(){FirstName="Edna", LastName="Miceli", Company="Sampler"},
            new Contact(){FirstName="Sue", LastName="Kownacki", Company="Juno Chefs Incorporated"},
            new Contact(){FirstName="Jesusa", LastName="Shin", Company="Carroccio"},
            new Contact(){FirstName="Rolland", LastName="Francescon", Company="Stanley"},
            new Contact(){FirstName="Pamella", LastName="Schmierer", Company="K Cs Cstm Mouldings Windows"},
            new Contact(){FirstName="Glory", LastName="Kulzer", Company="Comfort Inn"},
            new Contact(){FirstName="Shawna", LastName="Palaspas", Company="Windsor"},
            new Contact(){FirstName="Brandon", LastName="Callaro", Company="Jackson Shields Yeiser"},
            new Contact(){FirstName="Scarlet", LastName="Cartan", Company="Box"},
            new Contact(){FirstName="Oretha", LastName="Menter", Company="Custom Engineering Inc"},
            new Contact(){FirstName="Ty", LastName="Smith", Company="Bresler Eitel Framg Gllry Ltd"},
            new Contact(){FirstName="Xuan", LastName="Rochin", Company="Carol"},
            new Contact(){FirstName="Lindsey", LastName="Dilello", Company="Biltmore Investors Bank"},
            new Contact(){FirstName="Devora", LastName="Perez", Company="Desco Equipment Corp"},
            new Contact(){FirstName="Herman", LastName="Demesa", Company="Merlin Electric Co"},
            new Contact(){FirstName="Rory", LastName="Papasergi", Company="Bailey Cntl Co Div Babcock"},
            new Contact(){FirstName="Talia", LastName="Riopelle", Company="Ford Brothers Wholesale Inc"},
            new Contact(){FirstName="Van", LastName="Shire", Company="Cambridge Inn"},
            new Contact(){FirstName="Lucina", LastName="Lary", Company="Matricciani"},
            new Contact(){FirstName="Bok", LastName="Isaacs", Company="Nelson Hawaiian Ltd"},
            new Contact(){FirstName="Rolande", LastName="Spickerman", Company="Neland Travel Agency"},
            new Contact(){FirstName="Howard", LastName="Paulas", Company="Asendorf"},
            new Contact(){FirstName="Kimbery", LastName="Madarang", Company="Silberman"},
            new Contact(){FirstName="Thurman", LastName="Manno", Company="Honey Bee Breeding Genetics &"},
            new Contact(){FirstName="Becky", LastName="Mirafuentes", Company="Wells Kravitz Schnitzer"},
            new Contact(){FirstName="Beatriz", LastName="Corrington", Company="Prohab Rehabilitation Servs"},
            new Contact(){FirstName="Marti", LastName="Maybury", Company="Eldridge"},
            new Contact(){FirstName="Nieves", LastName="Gotter", Company="Vlahos"},
            new Contact(){FirstName="Leatha", LastName="Hagele", Company="Ninas Indian Grs & Videos"},
            new Contact(){FirstName="Valentin", LastName="Klimek", Company="Schmid"},
            new Contact(){FirstName="Melissa", LastName="Wiklund", Company="Moapa Valley Federal Credit Un"},
            new Contact(){FirstName="Sheridan", LastName="Zane", Company="Kentucky Tennessee Clay Co"},
            new Contact(){FirstName="Bulah", LastName="Padilla", Company="Admiral Party Rentals & Sales"},
            new Contact(){FirstName="Audra", LastName="Kohnert", Company="Nelson"},
            new Contact(){FirstName="Daren", LastName="Weirather", Company="Panasystems"},
            new Contact(){FirstName="Fernanda", LastName="Jillson", Company="Shank"},
            new Contact(){FirstName="Gearldine", LastName="Gellinger", Company="Megibow & Edwards"},
            new Contact(){FirstName="Chau", LastName="Kitzman", Company="Benoff"},
            new Contact(){FirstName="Theola", LastName="Frey", Company="Woodbridge Free Public Library"},
            new Contact(){FirstName="Cheryl", LastName="Haroldson", Company="New York Life John Thune"},
            new Contact(){FirstName="Laticia", LastName="Merced", Company="Alinabal Inc"},
            new Contact(){FirstName="Carissa", LastName="Batman", Company="Poletto"},
            new Contact(){FirstName="Lezlie", LastName="Craghead", Company="Chang"},
            new Contact(){FirstName="Ozell", LastName="Shealy", Company="Silver Bros Inc"},
            new Contact(){FirstName="Arminda", LastName="Parvis", Company="Newtec Inc"},
            new Contact(){FirstName="Reita", LastName="Leto", Company="Creative Business Systems"},
            new Contact(){FirstName="Yolando", LastName="Luczki", Company="Dal Tile Corporation"},
            new Contact(){FirstName="Lizette", LastName="Stem", Company="Edward S Katz"},
            new Contact(){FirstName="Gregoria", LastName="Pawlowicz", Company="Oh My Goodknits Inc"},
            new Contact(){FirstName="Carin", LastName="Deleo", Company="Redeker"},
            new Contact(){FirstName="Chantell", LastName="Maynerich", Company="Desert Sands Motel"},
            new Contact(){FirstName="Dierdre", LastName="Yum", Company="Cummins Southern Plains Inc"},
            new Contact(){FirstName="Larae", LastName="Gudroe", Company="Lehigh Furn Divsn Lehigh"},
            new Contact(){FirstName="Latrice", LastName="Tolfree", Company="United Van Lines Agent"},
            new Contact(){FirstName="Kerry", LastName="Theodorov", Company="Capitol Reporters"},
            new Contact(){FirstName="Dorthy", LastName="Hidvegi", Company="Kwik Kopy Printing"},
            new Contact(){FirstName="Fannie", LastName="Lungren", Company="Centro Inc"},
            new Contact(){FirstName="Evangelina", LastName="Radde", Company="Campbell"},
            new Contact(){FirstName="Novella", LastName="Degroot", Company="Evans"},
            new Contact(){FirstName="Clay", LastName="Hoa", Company="Scat Enterprises"},
            new Contact(){FirstName="Jennifer", LastName="Fallick", Company="Nagle"},
            new Contact(){FirstName="Irma", LastName="Wolfgramm", Company="Serendiquity Bed & Breakfast"},
            new Contact(){FirstName="Eun", LastName="Coody", Company="Ray Carolyne Realty"},
            new Contact(){FirstName="Sylvia", LastName="Cousey", Company="Berg"},
            new Contact(){FirstName="Nana", LastName="Wrinkles", Company="Ray"},
            new Contact(){FirstName="Layla", LastName="Springe", Company="Chadds Ford Winery"},
            new Contact(){FirstName="Joesph", LastName="Degonia", Company="A R Packaging"},
            new Contact(){FirstName="Annabelle", LastName="Boord", Company="Corn Popper"},
            new Contact(){FirstName="Stephaine", LastName="Vinning", Company="Birite Foodservice Distr"},
            new Contact(){FirstName="Nelida", LastName="Sawchuk", Company="Anchorage Museum Of Hist & Art"},
            new Contact(){FirstName="Marguerita", LastName="Hiatt", Company="Haber"},
            new Contact(){FirstName="Carmela", LastName="Cookey", Company="Royal Pontiac Olds Inc"},
            new Contact(){FirstName="Junita", LastName="Brideau", Company="Leonards Antiques Inc"},
            new Contact(){FirstName="Claribel", LastName="Varriano", Company="Meca"},
            new Contact(){FirstName="Benton", LastName="Skursky", Company="Nercon Engineering & Mfg Inc"},
            new Contact(){FirstName="Hillary", LastName="Skulski", Company="Replica I"},
            new Contact(){FirstName="Merilyn", LastName="Bayless", Company="20 20 Printing Inc"},
            new Contact(){FirstName="Teri", LastName="Ennaco", Company="Publishers Group West"},
            new Contact(){FirstName="Merlyn", LastName="Lawler", Company="Nischwitz"},
            new Contact(){FirstName="Georgene", LastName="Montezuma", Company="Payne Blades & Wellborn Pa"},
            new Contact(){FirstName="Jettie", LastName="Mconnell", Company="Coldwell Bnkr Wright Real Est"},
            new Contact(){FirstName="Lemuel", LastName="Latzke", Company="Computer Repair Service"},
            new Contact(){FirstName="Melodie", LastName="Knipp", Company="Fleetwood Building Block Inc"},
            new Contact(){FirstName="Candida", LastName="Corbley", Company="Colts Neck Medical Assocs Inc"},
            new Contact(){FirstName="Karan", LastName="Karpin", Company="New England Taxidermy"},
            new Contact(){FirstName="Andra", LastName="Scheyer", Company="Ludcke"},
            new Contact(){FirstName="Felicidad", LastName="Poullion", Company="Mccorkle"},
            new Contact(){FirstName="Belen", LastName="Strassner", Company="Eagle Software Inc"},
            new Contact(){FirstName="Gracia", LastName="Melnyk", Company="Juvenile & Adult Super"},
            new Contact(){FirstName="Jolanda", LastName="Hanafan", Company="Perez"},
            new Contact(){FirstName="Barrett", LastName="Toyama", Company="Case Foundation Co"},
            new Contact(){FirstName="Helga", LastName="Fredicks", Company="Eis Environmental Engrs Inc"},
            new Contact(){FirstName="Ashlyn", LastName="Pinilla", Company="Art Crafters"},
            new Contact(){FirstName="Fausto", LastName="Agramonte", Company="Marriott Hotels Resorts Suites"},
            new Contact(){FirstName="Ronny", LastName="Caiafa", Company="Remaco Inc"},
            new Contact(){FirstName="Marge", LastName="Limmel", Company="Bjork"},
            new Contact(){FirstName="Norah", LastName="Waymire", Company="Carmichael"},
            new Contact(){FirstName="Aliza", LastName="Baltimore", Company="Andrews"},
            new Contact(){FirstName="Mozell", LastName="Pelkowski", Company="Winship & Byrne"},
            new Contact(){FirstName="Viola", LastName="Bitsuie", Company="Burton & Davis"},
            new Contact(){FirstName="Franklyn", LastName="Emard", Company="Olympic Graphic Arts"},
            new Contact(){FirstName="Willodean", LastName="Konopacki", Company="Magnuson"},
            new Contact(){FirstName="Beckie", LastName="Silvestrini", Company="A All American Travel Inc"},
            new Contact(){FirstName="Rebecka", LastName="Gesick", Company="Polykote Inc"},
            new Contact(){FirstName="Frederica", LastName="Blunk", Company="Jets Cybernetics"},
            new Contact(){FirstName="Glen", LastName="Bartolet", Company="Metlab Testing Services"},
            new Contact(){FirstName="Freeman", LastName="Gochal", Company="Kellermann"},
            new Contact(){FirstName="Vincent", LastName="Meinerding", Company="Arturi"},
            new Contact(){FirstName="Rima", LastName="Bevelacqua", Company="Mcauley Mfg Co"},
            new Contact(){FirstName="Glendora", LastName="Sarbacher", Company="Defur Voran Hanley Radcliff"},
            new Contact(){FirstName="Avery", LastName="Steier", Company="Dill Dill Carr & Stonbraker Pc"},
            new Contact(){FirstName="Cristy", LastName="Lother", Company="Kleensteel"},
            new Contact(){FirstName="Nicolette", LastName="Brossart", Company="Goulds Pumps Inc Slurry Pump"},
            new Contact(){FirstName="Tracey", LastName="Modzelewski", Company="Kansas City Insurance Report"},
            new Contact(){FirstName="Virgina", LastName="Tegarden", Company="Berhanu International Foods"},
            new Contact(){FirstName="Tiera", LastName="Frankel", Company="Roland Ashcroft"},
            new Contact(){FirstName="Alaine", LastName="Bergesen", Company="Hispanic Magazine"},
            new Contact(){FirstName="Earleen", LastName="Mai", Company="Little Sheet Metal Co"},
            new Contact(){FirstName="Leonida", LastName="Gobern", Company="Holmes"},
            new Contact(){FirstName="Ressie", LastName="Auffrey", Company="Faw"},
            new Contact(){FirstName="Justine", LastName="Mugnolo", Company="Evans Rule Company"},
            new Contact(){FirstName="Eladia", LastName="Saulter", Company="Tyee Productions Inc"},
            new Contact(){FirstName="Chaya", LastName="Malvin", Company="Dunnells & Duvall"},
            new Contact(){FirstName="Gwenn", LastName="Suffield", Company="Deltam Systems Inc"},
            new Contact(){FirstName="Salena", LastName="Karpel", Company="Hammill Mfg Co"},
            new Contact(){FirstName="Yoko", LastName="Fishburne", Company="Sams Corner Store"},
            new Contact(){FirstName="Taryn", LastName="Moyd", Company="Siskin"},
            new Contact(){FirstName="Katina", LastName="Polidori", Company="Cape & Associates Real Estate"},
            new Contact(){FirstName="Rickie", LastName="Plumer", Company="Merrill Lynch"},
            new Contact(){FirstName="Alex", LastName="Loader", Company="Sublett"},
            new Contact(){FirstName="Lashon", LastName="Vizarro", Company="Sentry Signs"},
            new Contact(){FirstName="Lauran", LastName="Burnard", Company="Professionals Unlimited"},
            new Contact(){FirstName="Ceola", LastName="Setter", Company="Southern Steel Shelving Co"},
            new Contact(){FirstName="My", LastName="Rantanen", Company="Bosco"},
            new Contact(){FirstName="Lorrine", LastName="Worlds", Company="Longo"},
            new Contact(){FirstName="Peggie", LastName="Sturiale", Company="Henry County Middle School"},
            new Contact(){FirstName="Marvel", LastName="Raymo", Company="Edison Supply & Equipment Co"},
            new Contact(){FirstName="Daron", LastName="Dinos", Company="Wolf"},
            new Contact(){FirstName="An", LastName="Fritz", Company="Linguistic Systems Inc"},
            new Contact(){FirstName="Portia", LastName="Stimmel", Company="Peace Christian Center"},
            new Contact(){FirstName="Rhea", LastName="Aredondo", Company="Double B Foods Inc"},
            new Contact(){FirstName="Benedict", LastName="Sama", Company="Alexander & Alexander Inc"},
            new Contact(){FirstName="Alyce", LastName="Arias", Company="Fairbanks Scales"},
            new Contact(){FirstName="Heike", LastName="Berganza", Company="Cali Sportswear Cutting Dept"},
            new Contact(){FirstName="Carey", LastName="Dopico", Company="Garofani"},
            new Contact(){FirstName="Dottie", LastName="Hellickson", Company="Thompson Fabricating Co"}
        }.OrderBy(c => c.FullName).ToList();
        public static List<Contact> Contacts
        {
            get { return _contacts; }
        }
        
        /// <summary>
        /// Do a fuzzy search on all contacts and order results based on a pre-defined rule set
        /// </summary>
        /// <param name="query">The part of the name or company to look for</param>
        /// <returns>An ordered list of contacts that matches the query</returns>
        public static IEnumerable<Contact> GetMatchingContacts(string query)
        {
            return ContactSampleDataSource.Contacts
                .Where(c => c.FirstName.IndexOf(query, StringComparison.CurrentCultureIgnoreCase) > -1 ||
                            c.LastName.IndexOf(query, StringComparison.CurrentCultureIgnoreCase) > -1 ||
                            c.Company.IndexOf(query, StringComparison.CurrentCultureIgnoreCase) > -1)
                .OrderByDescending(c => c.FirstName.StartsWith(query, StringComparison.CurrentCultureIgnoreCase))
                .ThenByDescending(c => c.LastName.StartsWith(query, StringComparison.CurrentCultureIgnoreCase))
                .ThenByDescending(c => c.Company.StartsWith(query, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}