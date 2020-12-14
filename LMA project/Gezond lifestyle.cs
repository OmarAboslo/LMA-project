using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMA_project
{
    public partial class Sport : Form
    {
        public Sport()
        {
            InitializeComponent(); 
        }

        public double Snelheid(double uitslag)
        {
            double Gewicht = Convert.ToDouble(TextbGewicht.Text);
            double Gewenstegewicht = Convert.ToDouble(textBoxGewensteGewicht.Text);
           
            
            if (Gewicht < Gewenstegewicht)
            {
                if (RBNormaal.Checked == true)
                {

                uitslag += 250;
                }
                else if (RBSnel.Checked == true)
                {
                 uitslag += 500;
                }
                else if (RBZosnelmogelijk.Checked == true)
                {

                uitslag += 100;

                }
                return uitslag;
            }
            else if (Gewicht > Gewenstegewicht)
            { 
                if (RBNormaal.Checked == true)
                {
                    uitslag -= 250;
                }
                else if (RBSnel.Checked == true)
                {
           uitslag -= 500;
                }
                else if (RBZosnelmogelijk.Checked == true)
                {
           uitslag -= 1000; 
                }
                else
                {
      MessageBox.Show("Er zijn vragen die nog niet beantwoord zijn, conntroleer alle vragen en probeer opnieuw");
                }
                return uitslag;
            }
            return uitslag;
        }
        public double Actieflevel(double BMR)
        {
            double Result= 0;
            if (RBminderActief.Checked ==true)
            {
                Result = BMR * 1.2;
               
            }
            else if (RBredelijkActief.Checked == true)
            {
                Result = BMR * 1.375;
                
            }
            else if (RBheelactief.Checked == true)
            {
                Result = BMR * 1.55;
               
            }
            else if (RBextraactief.Checked== true)
            {
                Result = BMR * 1.725;
                
            }
            else if (RBergactief.Checked==true)
            {
                Result = BMR * 1.9;
            }
            return Result;

        }


      

        private void ButOk_Click_1(object sender, EventArgs e)
        {
            // gegevens van de gebruiker ophalen

            double Gewicht = Convert.ToDouble(TextbGewicht.Text);
            double Lengte = Convert.ToDouble(TextbLengte.Text);
            int leeftijd = Convert.ToInt32(textbLeeftijd.Text);
            this.Hide();
            Dieet_A form = new Dieet_A();


            if (RBJa.Checked == true)
            {
                MessageBox.Show("Overleg met jouw huisarts,voordat je gaat beginnen");
            }
            //man of vrouw
            if (RBMan.Checked == true)
            {
                //class BMR aanroepen
                BMR man = new BMR(Gewicht, Lengte, leeftijd);
                // method snelheid aanroepen
                form.Result.Text = Convert.ToString(Snelheid(Actieflevel(man.BMRMan())));
                form.ShowDialog();
            }
            else if (RBVrouw.Checked == true)
            {
                //class BMR aanroepen
                BMR vrouw = new BMR(Gewicht, Lengte, leeftijd);
                //// method snelheid aanroepen
                form.Result.Text = Convert.ToString(Snelheid(Actieflevel(vrouw.BMRMan())));
                form.ShowDialog();
            }

        }

    }
}
/*A                           Eenheid       Kcal   Eiwit   Koolh.   Vet
aalbessen                     100 gr        24     1.0     5.0     0.0
aardappelen                   100 gr        85     2.6    18.6     0.0
aardappelkroketten            100 gr       356    34.0    28.2    12.0
aardappelpuree                100 gr       100     2.8    11.0     5.0
aardappelsoesje               100 gr       188     5.3    16.4    11.2
aardappelzetmeel              100 gr       337     0.5    83.8     0.1
aardbeien                     100 gr        24     1.0     5.0     0.0
abrikoos                        1 stuk      20     0.0     5.0     0.0
achterham                     100 gr       130    18.0     1.0     6.0
all bran                      100 gr       267    14.0    46.0     3.0
amandelbroodje                100 gr       463     7.6    43.0    28.9
amandelen                     100 gr       578    18.3     4.3    54.2
americain                     100 gr       125    20.0     0.0     5.0
americain prepare             100 gr       244    16.0     0.0    20.0
amsoi (gekookt)               100 gr        28     2.0     5.0     0.0
ananas                        100 gr        88     0.0    22.0     0.0
andijvie                      100 gr        17     1.8     2.1     0.2
anijshagel                    100 gr       393     0.1    98.2     0.0
ansjovis in olie              100 gr       189    18.0     0.0    13.0
appel                           1 stuk      60     1.0    14.0     0.0
appelbeignet                  100 gr       190     2.6    18.6    11.7
appelcarre                    100 gr       318     3.7    38.6    16.6
appelflap                       1 stuk     146     2.0    12.0    10.0
appelmoes                     100 gr        76     0.0    19.0     0.0
appelstroop                     1 eetlpl    44     0.0    11.0     0.0
appeltaart                    100 gr       234     3.6    38.6     7.2
aquarius                        1 blikje    95     0.0    23.7     0.0
artisjok                      100 gr        59     2.4    12.2     0.1
asperges                      100 gr        16     1.0     3.0     0.0
atjar tjampoer                100 gr        24     1.0     5.0     0.0
aubergine                     100 gr        24     1.0     5.0     0.0
augurken                      100 gr        18     0.9     3.6     0.0
avocado                         1 stuk     226     4.0    12.0    18.0
B                           Eenheid       Kcal   Eiwit   Koolh.   Vet
babi pangang                  100 gr       217    13.6     3.9    16.4
babybel bonbel                100 gr       314    22.6     0.1    24.8
bacon                         100 gr       430    13.0     0.0    42.0
bak- en braadvet              100 gr       876     0.3     0.0    97.3
bakbokking                    100 gr       334    21.6     3.0    26.2
baklava                       100 gr       435     4.2    53.7    22.7
balisto                         1 stuk     223     4.0    27.0    11.0
bambix                        100 gr       344     9.5    72.0     2.0
bamboespruiten                100 gr        32     2.0     6.0     0.0
bami goreng                   100 gr       145     6.0    19.0     5.0
bamibal                       100 gr       274     7.0    30.0    14.0
banaan                          1 stuk     124     1.0    30.0     0.0
banketbakkersroom             100 gr       145     3.9    23.2     4.1
banketstaaf                   100 gr       462     7.6    43.0    28.9
barbecuesaus                  100 gr        92     1.0    22.0     0.0
basterdsuiker                 100 gr       380     0.0    95.0     0.0
bayonne-ham                   100 gr       259    24.0     0.2    18.0
belgian pickels(devos lemmens)100 gr        51     0.8     9.6     0.4 
berehap - bereklauw           100 gr       252     9.7     9.4    19.5
berlinerbol                   100 gr       386     5.5    39.1    23.1
beschuit                      100 gr       379     9.9    75.5     4.2
bichoc delacre                100 gr       465     5.3    72.5    17.1
bieflap                       100 gr       168    27.8     0.8     6.0
biefstuk                      100 gr       115    22.0     0.0     3.0
bierworstje - bifiworstje     100 gr       402    19.1     0.9    35.8
bieslook                      100 gr        57     4.0     8.0     1.0
bieten                        100 gr        20     2.0     3.0     0.0
big bacon (Quick)               1 stuk     501    27.2    21.9    33.8
big mac (McDonald's)            1 stuk     505    25.7    43.4    25.4
biogarde mager                100 gr        33     4.0     4.0     0.1
biogarde natuur               100 gr        57     4.6     6.3     1.5
biogarde vol                  100 gr        56     3.4     3.5     3.2
biogarde (halfvol)            100 gr        50     4.3     4.7     1.5
bisc & bounty                 100 gr       539     4.9    55.9    32.9
bisc & mars                   100 gr       523     5.3    61.4    28.5
bisc & snickers               100 gr       536     7.8    53.0    32.5
bisc & twix                   100 gr       518     5.4    61.6    27.8
biscuitje (groot)             100 gr       432     8.8    76.7    10.1
bitterbal                     100 gr       232    10.7    16.9    13.6
bizonsteak                    100 gr       101    23.0     0.0     1.0
bladerdeeg                    100 gr       390     7.0    41.0    22.0
bleekselderij                 100 gr        24     2.0     4.0     0.0
blinde vink                   100 gr       189    25.6     1.2     9.1
bloem                         100 gr       333    11.0    70.0     1.0
bloemkool                     100 gr        20     2.0     3.0     0.0
blue                          100 gr       353    21.1     0.0    29.8
bluefort                      100 gr       354    20.0     1.0    30.0
boerenkool                    100 gr        41     4.0     4.0     1.0
boerenkoolstamppot            100 gr        89     2.7    10.7     3.9
boerenpate                    100 gr       308    15.0     2.5    26.4
bokkepoot                     100 gr       446    16.0    55.0    18.0
bokking (gerookt)             100 gr       236    23.0     0.0    16.0
bokking (gestoomd)            100 gr       233    21.2     0.5    16.2
bonbon                        100 gr       409     4.5    62.8    15.6
bonbon (met likeur)           100 gr       351     3.0    42.2    18.9
bonen                         100 gr       266    20.0    43.0     1.5
borrelnootjes                 100 gr       518    15.0    45.0    31.0
borstplaat (room)             100 gr       328     0.8    72.2     4.1
borstplaat (water)            100 gr       380     0.0    95.0     0.0
bosbessen                     100 gr        35     0.3     7.4     0.5
bosbessen op siroop           100 gr       128     1.0    31.0     0.0
bossche bol                   100 gr       349     4.5    21.0    27.4
boter                          10 gr        75     0.1     0.1     8.2
boter (gezouten)              100 gr       761     0.9     0.0    84.2
boterhamworst                 100 gr       335    12.0     4.0    30.0
boterkoek                     100 gr       515     4.0    55.0    31.0
boterletter                   100 gr       461     7.6    43.0    28.9
boter (halfvol)               100 gr       390     6.3     0.3    40.5
boter (ongezouten)            100 gr       763     4.2     1.1    82.5
boudoir                       100 gr       395     7.4    84.0     3.3
bounty                          1 stuk     243     3.0    24.0    15.0
boursin                       100 gr       418    10.0     1.0    41.5
braadharing                   100 gr       219    17.0     4.0    15.0
braadworst (varken)           100 gr       308    22.2     0.9    24.0
braambessen                   100 gr        38     1.2     7.2     0.5
brado                         100 gr       236    23.0     0.0    16.0
bramen                        100 gr        37     1.0     6.0     1.0
bran buds                     100 gr       100     3.6    18.9     1.1
bressot                       100 gr       332     8.5     1.0    32.7
brie (50+)                    100 gr       317    22.0     1.0    25.0
brie (60+)                    100 gr       365    17.0     0.0    33.0
brinta                        100 gr       366    12.0    74.0     2.5
brinta fruitvit               100 gr       330     9.2    68.6     1.5
broccoli                      100 gr        20     2.0     3.0     0.0
brood (volkoren)              100 gr       208     5.7    40.0     2.8
brood (wit)                   100 gr       226     6.5    50.0     0.0
broodje (bruin)               100 gr       250     9.5    45.1     3.5
broodje (gemiddeld)           100 gr       240     8.7    45.8     2.5
broodje (luxe wit)            100 gr       294     9.3    53.1     5.0
broodje (meergranen)          100 gr       212     8.4    40.5     1.8
broodje (muesli)              100 gr       273     8.1    52.3     3.5
broodje (tarwe)               100 gr       250     9.5    45.1     3.5
broodje (volkoren)            100 gr       211     8.4    40.5     1.8
broodje (wit)                 100 gr       259     8.1    52.0     2.1
brood (gemiddeld)             100 gr       240     8.7    45.8     2.5
bruinbrood                    100 gr       250     9.5    45.1     3.5
bruine bonensoep              100 gr        46     3.5     7.5     0.3
bulgaarse yoghurt (fruit)     100 gr       124     5.0    17.0     4.0
bulgaarse yoghurt (mager)     100 gr        48     5.0     6.0     0.5
bulgaarse yoghurt (vol)       100 gr        89     4.8     7.0     4.7
C                           Eenheid       Kcal   Eiwit   Koolh.   Vet
cake                          100 gr       446     6.9    44.8    26.6
camembert (45+)               100 gr       284    25.0     1.0    20.0
camembert (50+)               100 gr       314    18.0     2.0    26.0
candybar                      100 gr       478     5.9    63.2    22.4
cantadou                      100 gr       328     6.0     3.5    32.3
capellini (Soubry)            100 gr       350    13.0    71.0     1.5 
carre confiture               100 gr       401     3.4    50.0    20.8
cashew-noten                  100 gr       578    18.0    32.0    42.0
casselerrib                   100 gr       183    18.0     3.0    11.0
cassoulet (William Saurin)    100 gr       109     7.6     8.4     5.0
cervela                       100 gr       387    18.0     0.0    35.0
champignons                   100 gr        16     3.0     1.0     0.0
chavroux                      100 gr       173    10.0     4.0    13.0
cheddar                       100 gr       401    26.0     0.0    33.0
cheeseburger (Quick)            1 stuk     275    16.8    24.7    12.1 
chili con carne               100 gr       145     8.7     8.0     8.7
chinese kool                  100 gr        12     1.2     1.2     0.3
chipolatapudding              100 gr       225     4.3    24.1    12.4
chips (light)                 100 gr       502     6.0    61.0    26.0
chips (naturel)               100 gr       544     6.0   4 9.0    36.0
choco (kwatta)                100 gr       362     1.9    71.5     7.6
chocolade (melk)              100 gr       518     6.6    54.7    30.3
chocolade (melk)              100 gr       528     8.0    52.0    32.0
chocolade (met noten)         100 gr       608    10.3    30.0    49.6
chocolade (puur)              100 gr       507     5.0    51.0    31.5
chocolade (puur)              100 gr       512     4.0    52.0    32.0
chocoladebiscuit              100 gr       470     6.9    63.8    20.8
chocoladehagelslag            100 gr       431     6.1    63.6    16.9
chocoladekorrels              100 gr       437     6.5    63.5    17.5
chocolademelk (halfvol)       100 gr        84     3.7    13.3     1.8
chocolademelk (mager)         100 gr        58     3.6    10.4     0.3
chocolademelk (vol)           100 gr        79     3.4    11.1     2.4
chocolademousse               100 gr       252     2.5    26.3    15.2
chocoladepasta                100 gr       578     3.0    56.0    38.0
chocoladepudding              100 gr       125     4.0    20.0     3.2
chocoladesaus                 100 gr       254     2.0    57.0     2.0
chocoladevla (mager)          100 gr        77     3.3    15.5     0.2
chocoladevla (vol)            100 gr        86     3.3    12.5     2.6
chocoladevlokken (melk)       100 gr       446     8.0    63.0    18.0
chocoladevlokken (puur)       100 gr       429     5.0    64.0    17.0
chocomousse (danone)          100 gr        91     2.1    12.2     3.7
chocoprince                   100 gr       482     5.6    67.5    21.1
citroen                         1 stuk      10     0.0     2.5     0.0
cocktailsaus (devos lemmens)  100 gr       582     1.2     7.1    61.0
confiture                     100 gr       262     0.5    65.0     0.0
corned beef                   100 gr       289    16.0     0.0    25.0
cornetto                        1 stuk     262     3.5    26.0    16.0
cornflakes                    100 gr       381     8.5    84.0     1.2
cottage cheese                100 gr        93    11.2     3.2     3.9
courgette                     100 gr         6     0.5     1.0     0.0
couscous                      100 gr       133     4.4    28.0     0.4
cracotte                      100 gr       477    11.0    97.0     5.0
cranberriecompote             100 gr        81     0.0    20.3     0.0
cream cracker                 100 gr       465     8.0    70.0    17.0
creme fraiche                 100 gr       344     2.2     3.0    35.9
cremetaart                    100 gr       477     5.0    40.0    33.0
croissant                       1 stuk     130     4.0    24.0     2.0
cruesli                       100 gr       389    10.6    68.3     8.2
curry (devos lemmens)         100 gr       647     1.1     2.7    70.2 
curryketchup                  100 gr       104     0.9    25.3     0.0
custardpoeder                 100 gr       340     0.0    85.0     0.0
D                           Eenheid       Kcal   Eiwit   Koolh.   Vet
dadels (vers)                 100 gr       165     2.0    37.0     1.0
dadels (geconfijt)            100 gr       300     2.0    73.0     0.0
danette chocolade             100 gr       148     4.9    21.2     4.8
danette vanille               100 gr       124     4.7    16.9     4.2
danish blue                   100 gr       353    20.0     1.0    30.0
dextro-energie (tabletten)    100 gr       364     0.0    91.0     0.0
djoez                         100 gr        51     0.9    11.8     0.1
donut                         100 gr       413     6.2    34.6    27.8
doperwten                     100 gr        60     5.0    10.0     0.0
doperwten en wortelen         100 gr        36     3.3     5.8     0.0
dorade                        100 gr       106    17.5     0.0     4.0
doritos nacho cheese          100 gr       526     6.0    58.0    30.0
double chicken (Quick)          1 stuk     465    19.6    25.3    31.7
drinkyoghurt (Inza)           100 gr        60     2.0    12.5     0.2
drinkyoghurt (Campina)        100 ml        62     2.7    12.1     0.0
drop (engelse)                100 gr       362     4.0    82.0     2.0
drop (gemiddeld)              100 gr       309     4.3    73.0     0.0
drop (zoet)                   100 gr       348    10.0    77.0     0.0
drop (zout)                   100 gr       336     9.0    75.0     0.0
druiven                       100 gr        66     0.5    16.0     0.0
dubbeldrank                   100 gr        52     0.3    12.8     0.0
E                           Eenheid       Kcal   Eiwit   Koolh.   Vet
edammer                       100 gr       314    28.0     1.0    22.0
eend                          100 gr       217    18.3     0.0    16.0
eendenfilet                   100 gr       341    20.0     0.0    29.0
ei                              1 stuk      82     7.0     0.0     6.0
ei-eiwit                        1 stuk      16     4.0     0.0     0.0
eierkoek                        1 stuk      85     1.0    18.0     1.0
eiersalade                    100 gr       246     6.4     8.3    20.9
emmental                      100 gr       390    27.0     3.0    30.0
entrecote                     100 gr       189    25.6     1.2     9.1
erwten                        100 gr        81     6.5    12.6     0.5
erwten & wortelen             100 gr        45     3.0     7.3     0.4
evergreen                       1 stuk      73     2.0    13.0     1.5
evergreen (krenten)           100 gr       373     9.0    73.0     5.0
extran eiwitdrank             100 gr        98    12.5    11.5     0.3
extran energiedrank           100 gr       160     0.0    40.0     0.0
extran energiereep m. muesli  100 gr       367     5.6    76.0     4.5
extran hypotone dorstlesser   100 gr        16     0.0     4.1     0.0
F                           Eenheid       Kcal   Eiwit   Koolh.   Vet
feta                          100 gr       248    15.6     1.5    20.0
filet americain               100 gr       161    18.5     2.2     8.7
filet d'anvers                100 gr       158    26.0     0.0     6.0
filet de york                 100 gr       146    22.0     1.0     6.0
finesse (Gervais)             100 gr       210     2.7     4.8    20.0
fishsticks                    100 gr       228    18.0    12.0    12.0
flantaart                     100 gr       227     6.0    31.5     8.5
flensje                       100 gr       157     6.4    18.4     6.5
foe yung hai                  100 gr       127     5.7     7.7     8.2
forel                         100 gr        99    18.0     0.0     3.0
frambozen                     100 gr        30     1.3     5.6     0.3
frambozen op siroop           100 gr        92     0.0    23.0     0.0
frangipane                    100 gr       478     5.0    65.0    22.0
fricandeau (varkens)          100 gr       151    31.2     0.0     2.9
friese nagelkaas 20+          100 gr       269    38.0     0.0    13.0
friese nagelkaas 40+          100 gr       327    25.5     0.1    25.0
frieten                       100 gr       456    40.0    38.0    16.0
frikadellen (Beckers)         100 gr       259    12.0     7.0    20.0
frikadelsaus                  100 gr       231     1.0    23.0    15.0
fritessaus (25% olie)         100 gr       282     0.5    11.6    26.0
fritessaus. 35% olie          100 gr       372     0.0    12.0    36.0
frituurvet                    100 gr       898     0.1     0.3    99.7
frituurvet (vloeibaar)        100 gr       900     0.0     0.0   100.0
fruitcoctail                  100 gr        68     0.0    17.0     0.0
fruitsap ( sinas )             25 cl       122     2.0    28.5     0.0
G                           Eenheid       Kcal   Eiwit   Koolh.   Vet
gado gado                     100 gr       173     7.2     7.8    12.6
galette                       100 gr       530     6.7    65.0    27.0
gamba                         100 gr       137    18.5     0.0     7.0
gans                          100 gr       350    15.6     0.0    32.0
ganzelever                    100 gr       462     7.0     6.0    45.6
garderoom                     100 gr       253     3.0     4.0    25.0
garnalen                      100 gr        90    18.0     0.0     2.0
gebonden soep                 100 gr        37     2.2     0.9     2.7
gebraden gehakt               100 gr       342    15.0     3.0    30.0
gehakt-tomatensaus            100 gr       138    11.7     1.1     9.7
gehakt (gemengd)              100 gr       348    15.0     0.0    32.0
geitekaas                     100 gr       205    13.0     0.0    17.0
geitemelk                     100 gr        70     3.4     4.4     4.3
gekookte worst                100 gr       380    12.0     2.0    36.0
gelatine                      100 gr       235    43.0     0.0     7.0
gember op siroop              100 gr       276     0.0    69.0     0.0
gepelde tomaten (cirio)       100 gr        23     1.3     4.0     0.2
geraspte kaas (volvet)        100 gr       385    24.9     0.4    31.5
gestampte muisjes             100 gr       389     0.0    95.0     1.0
gevogeltegehakt               100 gr       171    20.2     0.0    10.0
gevulde koek                  100 gr       435     5.5    61.1    18.8
gevulde speculaas             100 gr       488     8.6    52.8    27.0
giant (quick)                   1 stuk     535    25.0    24.5    37.4
gierst                        100 gr       109     3.6    23.1     0.3
gomasio                       100 gr       524    21.8     5.0    46.3
gorgonzola                    100 gr       340    19.1     0.2    29.2
gouda                         100 gr       366    25.5     0.2    29.2
goudbrasem                    100 gr       103    19.0     0.0     3.0
goudse kaas                   100 gr       385    24.9     0.4    31.5
goulash                       100 gr       155     9.5     2.5    11.9
granaatappel                  100 gr        62     1.0    13.7     0.3
granny (amandel-abrikoos)       1 stuk     131     2.1    19.2     5.1
granny (chocolade)              1 stuk      96     1.9    19.2     1.3
grapefruit                    100 gr        30     0.9     6.6     0.0
grapefruit op siroop          100 gr        64     1.0    15.0     0.0
grapefruitsap                 100 gr        30     0.4     7.0     0.1
griekse noedels               100 gr       355    13.0    73.0     1.5
groene aalbes                 100 gr        40     0.8     8.8     0.2
groene erwten                 100 gr       109     8.4    17.2     0.8
groene kool                   100 gr        37     3.0     4.0     1.0
groentesaus uit pakje         100 gr        62     1.7    10.6     1.4
groentespread                 100 gr        20     1.0     4.0     0.0
gruyere                       100 gr       435    29.0     1.0    35.0
guave                         100 gr        72     1.0    17.0     0.0
H                           Eenheid       Kcal   Eiwit   Koolh.   Vet
haas                          100 gr       113    21.5     0.0     3.0
hachee                        100 gr        89     6.8     2.8     5.6
hagelslag melk                100 gr       427     6.5    66.4    15.1
hagelslag puur                100 gr       403     3.4    59.9    16.7
halfvolle koffiemelk          100 ml       100     6.3     9.8     4.0
halvarine                     100 gr       360     0.0     0.0    40.0
halvarineprodukt (-40%)       100 gr       259     2.7     2.2    26.7
ham-kaassaus                  100 gr       174    10.2     6.2    12.0
ham (rauw, gerookt)           100 gr       369    18.0     0.0    33.0
hamburger (Quick)               1 stuk     266    13.1    26.8    11.8
hamlappen                     100 gr       182    31.3     0.0     6.3
hangop                        100 gr        63    10.0     3.5     1.0
haring                        100 gr       297    18.0     0.0    25.0
haring in tomatensaus         100 gr       162    15.0     2.0    10.5
haring (gerookt)              100 gr       259    22.2     0.0    19.0
haring (zoute)                100 gr       168    19.2     0.5     9.9
haring (zure)                 100 gr       208    16.0     0.0    16.0
hartige taart                 100 gr       172     8.9    13.7     9.1
hartige taart (bladerdeeg)    100 gr       273    10.8     9.9    21.2
hausmacher                    100 gr       325    16.0     0.0    29.0
haverkoek                     100 gr       344     8.2    53.8    10.7
havermout                     100 gr       363    13.0    62.0     7.0
havermoutpap                  100 gr        74     3.9     7.5     3.2
hazelnootpasta                100 gr       538     7.4    59.0    30.3
hazelnoten                    100 gr       644    11.9    10.5    61.6
heilbot                       100 gr       113    17.0     0.0     5.0
heldere soep                  100 gr        39     4.0     2.3     1.5
hoestbonbon                   100 gr       396     0.6    98.4     0.0
honing                          1 eetlpl    68     1.0    16.0     0.0
hopje                         100 gr       380     0.0    95.0     0.0
hot ketchup                   100 gr       104     0.9    25.3     0.0
hotdog                        100 gr       295     9.8    37.5    11.8
hotdog relish                 100 gr       104     0.0    26.0     0.0
hutspot                       100 gr        62     1.5     8.2     2.6
huttenkase                    100 gr        93    11.6     1.9     4.3
huzarenslaatje                100 gr       105     7.9     9.0     4.2
I                           Eenheid       Kcal   Eiwit   Koolh.   Vet
ijs                           100 gr       186     3.0    19.7    10.6
ijs (conotop)                 100 gr       246     6.0    24.0    14.0
ijs (met chocolade)           100 gr       218     3.2    22.8    12.7
ijs (room)                    100 gr       181     3.0    22.0     9.1
ijs (sorbet)                  100 gr       106     0.5    26.0     0.0
ijs (yoghurt)                 100 gr       107     4.0    16.0     3.0
ijscoupe met likeur           100 gr       164     2.3    21.2     7.8
ijslolly - waterijs           100 gr        73     0.0    18.2     0.0
ijswafeltje (koekje)          100 gr       433     8.8    76.7    10.1
irish coffee                  100 gr       108     0.6     5.2     9.4
isostar energiedrank          100 gr        28     0.0     7.0     0.0
italiaanse schotel (zwan)     100 gr       101     4.0    10.0     5.0
J                           Eenheid       Kcal   Eiwit   Koolh.   Vet
jachtschotel                  100 gr       101     5.0     9.0     5.0
jam  (marmelade)              100 gr       240     0.2    60.0     0.0
jam (halva en light)          100 gr       112     0.0    28.0     0.0
japanse mix                   100 gr       362     8.0    73.7     3.9
K                           Eenheid       Kcal   Eiwit   Koolh.   Vet
kaas 20+                      100 gr       269    38.0     0.0    13.0
kaas 40+                      100 gr       327    25.5     0.1    25.0
kaas ( trenta )               100 gr       370    25.0     0.0    30.0
kaas (edammer)                100 gr       368    25.0     4.0    28.0
kaas (gouda)                  100 gr       385    26.0     5.0    29.0
kaas (light)                  100 gr       154    14.5     5.0     8.5
kaas (parmezaan)              100 gr       411    40.0     2.0    27.0
kaas (volvet)                 100 gr       384    24.9     0.4    31.5
kaasprodukt 30+               100 gr       283    31.7     1.0    17.0
kaasprodukt (volvet)          100 gr       370    25.0     0.0    30.0
kaassoesje                    100 gr       334    12.0     9.0    27.8
kaaswafel                     100 gr       565    14.3    37.4    39.9
kabeljauw                     100 gr        76    18.0     0.0     0.5
kaki                          100 gr        66     0.5    16.0     0.0
kalfsentrecote                100 gr       189    25.6     1.2     9.1
kalfsfricandeau (beleg)       100 gr       156    31.9     0.0     3.2
kalfsgehakt                   100 gr       185    18.0     0.0    12.5
kalfslapjes                   100 gr       102    21.0     0.0     2.0
kalfslever                    100 gr       185    28.0     2.0     7.2
kalfstong                     100 gr       132    17.5     1.0     6.5
kalfszwezerik                 100 gr       218     5.0     4.6    20.0
kalkoen                       100 gr       143    20.0     0.0     7.0
kalkoenfilet                  100 gr        85    19.0     0.0     1.0
kano                          100 gr       435     5.5    61.1    18.8
kapucijners                   100 gr       106     8.0    17.2     0.6
karbonade (haas)              100 gr       156    26.0     0.0     5.8
karbonade (hals)              100 gr       272    27.6     0.0    18.0
karbonade (rib)               100 gr       211    28.3     0.5    10.7
karbonade (schouder)          100 gr       272    27.6     0.0    18.0
karnemelk                      25 cl        65     7.5     8.8     0.0
karper                        100 gr       115    18.0     0.0     4.8
kastanjes                     100 gr       165     4.0    35.0     1.0
katenspek                     100 gr       403    15.2     0.4    37.9
kauwgom                       100 gr       280     0.0    70.0     0.0
kaviaar                       100 gr       244    26.1     0.0    15.5
kefir                         100 gr        55     3.1     3.8     3.0
kellogg's all bran            100 gr       267    14.0    46.0     3.0
kellogg's choco pops          100 gr       374     5.0    84.0     2.0
kellogg's cornflakes          100 gr       367     8.0    82.0     0.8
kellogg's frosties            100 gr       377     5.0    88.0     0.5
kellogg's fruit & fiber       100 gr       357     9.0    69.0     5.0
kellogg's muesli              100 gr       362    10.0    67.0     6.0
kellogg's raisin bran         100 gr       318     8.0    67.0     2.0
kellogg's rice crisp          100 gr       377     6.0    86.0     1.0
kellogg's smacks                1 reep      91     2.0    14.0     3.0
kellogg's special k           100 gr       369    14.0    76.0     1.0
kernhemmer                    100 gr       413    20.0     0.0    37.0
kerriesaus                    100 gr       278     0.5    13.0    25.0
kersen                        100 gr        64     1.0    15.0     0.0
kersen op siroop              100 gr        76     1.0    18.0     0.0
kersenbonbon                  100 gr       350     3.0    42.2    18.9
kerstkrans                    100 gr       461     7.6    43.0    28.9
kervel                        100 gr        71     4.0    11.5     1.0
ketchup                         1 eetlpl    16     0.0     4.0     0.0
ketjap                          1 eetlpl    20     1.0     4.0     0.0
ketjap asin                   100 gr       120    12.0    18.0     0.0
ketjap manis                  100 gr       136    10.0    24.0     0.0
kidney beans                  100 gr        95     7.1    15.2     0.7
kievietsbonen                 100 gr       265    20.0    43.0     1.5
kikkerbil                     100 gr        68    16.4     0.0     0.3
kikkererwten                  100 gr       163     8.0    26.0     3.0
kinderbiscuit                 100 gr       396     9.0    72.0     8.0
kip-kap                       100 gr       207    18.0     0.0    15.0
kip-kerriesalade              100 gr       280     5.5     8.7    24.8
kipburger                     100 gr       306    14.5     9.9    23.2
kipnugget - kipkantje         100 gr       272    17.5    12.2    17.1
kippebouillion                100 ml        10     0.6     2.0     0.0
kippelever                    100 gr       184    28.0     2.0     7.2
kippenfilet                   100 gr       111    21.0     0.0     3.0
kippenham                     100 gr        88    20.0     2.0     0.0
kippepoot                     100 gr       229    26.4     0.0    13.7
kiprollade                    100 gr       165    24.0     1.7     7.0
kipschnitzel (gepaneerd)      100 gr       217    17.5     8.3    12.7
kiri creme                    100 gr       341     8.5     2.5    33.0
kit kat                       100 gr       482     5.6    67.5    21.1
kiwi                            1 stuk      24     0.0     6.0     0.0
klapstuk                      100 gr       265    34.0     0.0    14.4
knackebrod wasa               100 gr       350    11.0    72.0     2.0
knackebrod (lichtgewicht)     100 gr       374    10.0    79.0     2.0
knakworst                     100 gr       297    10.9     2.5    27.1
knoflook                        1 teentje   14     0.3     0.0     1.4
knolselderij                  100 gr        36     2.0     7.0     0.0
koffie verkeerd               100 gr        29     2.3     2.8     1.0
koffiebroodje                 100 gr       329     7.0    55.0     9.0
koffiemelk (halfvol)          100 gr       104     7.8     9.3     4.0
koffiemelk (mager)            100 gr        77     7.7    11.2     0.2
koffiemelk (vol)              100 gr       152     8.4    10.7     8.4
koffiemelkpoeder              100 gr       550     4.0    55.0    35.0
koffiemelkprodukt (halfvol)   100 gr       104     7.2    10.0     4.0
koffiemelkprodukt (vol)       100 gr       136     7.5     9.5     7.6
koffieroom                    100 gr       206     2.7     3.8    20.0
koffiewitmaker                100 gr       551     4.0    55.0    35.0
kokosbrood                    100 gr       422     4.0    34.0    30.0
kokosmakaron                  100 gr       451     4.0    57.0    23.0
kokosnoot                     100 gr       389     4.0    10.0    37.0
komkommer                     100 gr         8     1.0     1.0     0.0
komkommerspread               100 gr       157     1.0    13.5    11.0
konijn                        100 gr       160    21.0     1.0     8.0
koolraap                      100 gr        12     1.0     2.0     0.0
koolrabi                      100 gr        24     2.0     4.0     0.0
koolvis                       100 gr        72    18.0     0.0     0.0
korstgebak                    100 gr       611     7.0    40.0    47.0
kouseband                     100 gr        40     3.0     7.0     0.0
krab                          100 gr        82    16.0     0.0     2.0
kreeft                        100 gr        82    16.0     0.0     2.0
krenten                       100 gr       308     2.0    75.0     0.0
krentenbol                    100 gr       267     8.0    51.7     3.2
krentenbrood                  100 gr       255     7.0    50.0     3.0
krentenbrood (volkoren)       100 gr       230     7.1    47.4     1.4
krieken                       100 gr        39     0.2     9.0     0.2
krisprol                      100 gr       404    12.4    75.0     6.0
kroepoek                      100 gr       498     4.0    62.0    26.0
kroket                        100 gr       233    10.7    16.9    13.6
kruimelvlaai                  100 gr       293     5.9    40.4    12.0
kruisbessen                   100 gr        40     1.0     9.0     0.0
krulandijvie                  100 gr        13     1.8     0.9     0.2
kumquat                       100 gr        42     1.1     7.4     0.9
kwark vruchten (mager)        100 gr       124     7.0    15.0     4.0
kwark ( mager )               100 gr        64    13.0     3.0     0.0
kwark (vol)                   100 gr       159    11.1     3.2    11.4
kwarktaart                    100 gr       228     4.9    27.2    11.1
L                           Eenheid       Kcal   Eiwit   Koolh.   Vet
lamsbout                      100 gr       350    25.8     0.0    27.4
lamsfilet                     100 gr       143    20.0     0.0     7.0
lamskarbonade                 100 gr       350    25.8     0.0    27.4
lamskotelet                   100 gr       279    18.0     0.0    23.0
lange vingers                 100 gr       399     7.0    77.0     7.0
langoest                      100 gr        84    17.2     1.3     1.1
langoestine                   100 gr        82    19.0     0.0     0.7
lasagna. m. vlees & saus      100 gr       158     6.7     9.2    10.5
leidse kaas 20+               100 gr       269    38.0     0.0    13.0
lekkerbekje                   100 gr       219    24.9     2.1    12.3
lever                         100 gr       133    20.0     2.0     5.0
leverpastei                   100 gr       317    14.0     0.0    29.0
leverworst                    100 gr       421    12.0     1.0    41.0
leverworst ( saksische )      100 gr       384    13.0     2.0    36.0
limburgse kaas                100 gr       281    21.0     2.0    21.0
linzen ( gedroogd )           100 gr        32     3.0     5.0     0.0
linzensoep                    100 gr        50     1.6     5.1     2.6
lion                            1 stuk     193     2.0    26.0     9.0
loempia                       100 gr       176     7.0    18.6     8.2
lolly                         100 gr       380     0.0    95.0     0.0
lychee                        100 gr        68     1.0    16.0     0.0
M                           Eenheid       Kcal   Eiwit   Koolh.   Vet
maaltijdsoep                  100 gr        63     3.0     6.0     3.0
maaslander                    100 gr       370    25.0     0.0    30.0
macaroni                      100 gr       358    13.0    72.0     2.0
madeleine (lotus)             100 gr       437     6.0    53.0    21.0
magnum (ola)                    1 stuk     300     4.0    26.0    20.0
mais                          100 gr       114     3.3    23.0     1.0
maisgriesmeel                 100 gr       357     8.8    78.0     1.1
maiskorrels                   100 gr        70     2.7    12.0     1.3
maizena                       100 gr       337     0.0    84.0     0.1
makaron                       100 gr       393     4.0    65.0    13.0
makreel                       100 gr       158    17.0     0.0    10.0
mandarijn                       1 stuk      16     0.0     4.0     0.0
mandarijnen op siroop         100 gr        56     0.0    14.0     0.0
mango                           1 stuk      64     1.0    15.0     0.0
mango chutney                 100 gr       208     0.0    52.0     0.0
marcassin                     100 gr       104    21.0     0.4     2.0
maredsous                     100 gr       315    23.0     0.5    24.5
margarine (60-70% vet)        100 gr       589     0.2     0.8    65.0
margarine (dieet)             100 gr       748     0.2     0.6    82.8
margarine (gezouten)          100 gr       747     0.0     0.0    83.0
marmite (gistextract)         100 gr       166    41.4     0.0     0.1
mars                            1 stuk     267     3.0    39.0    11.0
marsepein                     100 gr       360     8.0    64.0     8.0
marsh mellows                 100 gr       328     2.0    80.0     0.0
mascarpone                    100 gr       457     5.2     4.3    46.5
matse                         100 gr       325    11.0    68.0     1.0
mayonaise 50%                   1 eetlpl    98     2.0     0.0    10.0
mayonaise 80%                   1 eetlpl   144     0.0     0.0    16.0
mayonaise (effi dressing)      1 kofflpl    47     0.0     0.5     5.0
meergranenbrood               100 gr       212     8.4    40.5     1.8
melk (half volle)              10 cl        50     4.0     5.0     1.5
melk (magere)                  10 cl        33     3.2     4.9     0.1
melk (volle)                   10 cl        64     3.2     4.7     3.6
meloen (honing)               100 gr        28     1.0     6.0     0.0
meloen (water)                100 gr        24     1.0     5.0     0.0
mergpijpje                    100 gr       443     6.6    49.5    24.3
mie                           100 gr        94     3.1    19.3     0.5
mierik                        100 gr        63     2.8    12.4     0.3
mihoen                        100 gr       144     3.0    33.0     0.0
Milk & Fruit (Friesche Vlag)  100 ml        75     2.5    14.0     1.0
minarine alpro                100 gr       362     1.5     0.0    39.5
minestronesoep                100 gr        74     5.0     9.0     2.0
mini boss nature              100 gr       120     3.5    18.5     3.5
mini pizza                    100 gr       287    12.0    35.0    11.0
minute soup                     1 pakje     91     2.8    12.8     3.2
miso                          100 gr       116    11.7     6.2     5.0
mispel                        100 gr        48     0.4    10.6     0.4
mixed pickles                   1 eetlpl     4     0.0     1.0     0.0
mokkataart                    100 gr       477     5.0    40.0    33.0
monchou                       100 gr       332     8.5     1.0    32.7
moorkop                         1 stuk     201     3.0    18.0    13.0
mortadella                    100 gr       345    12.4     0.0    32.8
mosselen                      100 gr        49    10.0     0.0     1.0
mosterd (devos lemmens)       100 gr       112     6.5     4.5     7.5
moussaka                      100 gr        93     4.5     7.5     5.0
mozzarella                    100 gr       299    26.5     1.0    21.0
muesli                        100 gr       374     6.5    68.0     8.5
muisjes                       100 gr       393     0.1    98.2     0.0
m&m met chocolade             100 gr       483     4.6    70.5    20.3
m&m met pinda's               100 gr       514    10.2    57.3    27.1
N                           Eenheid       Kcal   Eiwit   Koolh.   Vet
nasi goreng zonder ei         100 gr       126     4.1    21.8     2.5
nasibal                       100 gr       301     6.0    31.0    17.0
nectarine                       1 stuk      50     0.5    12.0     0.0
negerzoen                     100 gr       365     4.7    38.6    21.3
netmeloen                     100 gr        24     0.0     6.0     0.0
nogat                         100 gr       472     6.0    67.0    20.0
nutella (choco)               100 gr       533     6.5    57.0    31.0
O                           Eenheid       Kcal   Eiwit   Koolh.   Vet
oesters                       100 gr        65     9.0     5.0     1.0
olie                            1 eetlpl   108     0.0     0.0    12.0
olijven                       100 gr       232     6.0     7.0    20.0
ontbijtkoek                   100 gr       288     4.0    68.0     0.0
ontbijtkoek met noten         100 gr       367     8.7    55.5    12.3
ontbijtspek                   100 gr       785     5.0     0.0    85.0
ossehaas                      100 gr       189    25.6     1.2     9.1
osseworst                     100 gr       232    25.0     0.7    14.4
ovenfrites                    100 gr       286     5.8    46.0     8.8
P                           Eenheid       Kcal   Eiwit   Koolh.   Vet
paardenbiefstuk               100 gr       107    20.0     0.0     3.0
paardenrookvlees              100 gr        88    22.0     0.0     0.0
paling                        100 gr       209    14.0     0.0    17.0
paling (gerookt)              100 gr       286    17.9     0.0    23.8
paling (gestoofd)             100 gr       175    16.0     0.0    12.4
palingworst                   100 gr       424    12.0     4.0    40.0
palmhart                      100 gr        36     2.1     5.5     0.6
pandabrood                    100 gr       270    14.4    36.4     7.5
paneermeel                      1 eetlpl    37     1.0     6.0     1.0
pannenkoek                    100 gr       194     8.3    29.2     4.9
papaya                        100 gr        36     1.0     8.0     0.0
paprika (rood)                100 gr        48     2.0    10.0     0.0
paprika (groen)               100 gr        28     1.0     6.0     0.0
pap. halfvolle melk           100 gr        69     4.2     9.8     1.5
paranoten                     100 gr       683    15.0     5.0    67.0
parelhoen                     100 gr       150    23.1     0.0     6.4
parmazaan                     100 gr       375    35.6     0.0    25.8
parmezaanse kaas              100 gr       411    40.0     2.0    27.0
parovita                      100 gr       437    10.0    70.0    13.0
passendale                    100 gr       357    20.0     4.0    29.0
passievrucht                  100 gr       102     2.0    19.0     2.0
pasta                         100 gr       347    12.0    71.3     1.5
pastei (herta-fijn)           100 gr       242    15.5     0.0    20.0
pasteibakje                   100 gr       655     7.0    42.0    51.0
pat‚                          100 gr       420    11.0     4.0    40.0
patrijs                       100 gr       115    25.0     0.5     1.4
paturain                      100 gr       364    10.0     0.0    36.0
peer                            1 stuk      52     1.0    12.0     0.0
pekelvlees                    100 gr       289    16.0     0.0    25.0
pennywafel                    100 gr       482     5.6    67.5    21.1
pensen (witte)                100 gr       269    11.0     0.0    25.0
pensen (zwarte)               100 gr       371    16.0     2.5    33.0
peperkoek                     100 gr       263     3.4    60.4     0.9
pepermunt                     100 gr       396     0.0    99.0     0.0
pepernoot                     100 gr       489     6.1    68.3    21.3
pere joseph                   100 gr       321    22.7     0.0    25.6
peren op siroop               100 gr        60     0.3    14.7     0.0
perenstroop                   100 gr       226     1.9    54.6     0.0
peresap                       100 gr        35     0.1     8.7     0.0
perzik                          1 stuk      46     0.8    10.5     0.1
perziken op siroop            100 gr        70     0.6    17.0     0.0
pesto (Bertoli)               100 gr       391     5.6     4.8    39.0
peterselie                    100 gr        56     4.0    10.0     0.0
petit beurre (match)          100 gr       507     6.6    67.6    23.3
petit filous yoplait          100 gr       128     7.6    13.7     4.8
petit four                    100 gr       477     5.0    40.0    33.0
petit gervais (calcium)       100 gr       142     6.0    16.0     6.0
petit gervais (fruit)         100 gr       171     6.5    18.0     8.1
petit suisse creme            100 gr       146     8.7     3.3    10.9
piccalilly                      1 eetlpl     8     0.0     2.0     0.0
pijnboompitten                100 gr       670    12.5    20.0    60.0
pims cake                     100 gr       312     4.5    52.0     9.5
pinda's (gezouten)            100 gr       625    28.8     8.6    52.8
pinda's (ongezouten)          100 gr       629    28.5    12.6    51.6
pindakaas                     100 gr       647    26.2    16.2    53.1
pindanoten                    100 gr       617    26.0    18.0    49.0
pistachenootjes (gepeld)      100 gr       591    19.0     5.0    55.0
pistolet                        1 stuk     104     3.0    23.0     0.0
pittabroodje                  100 gr       257     8.6    53.0     1.2
pittasaus (devos lemmens)     100 gr       586     0.9     6.3    61.7
pizza                         100 gr       224     7.7    23.5    11.0
poestasaus                    100 gr       100     2.0    23.0     0.0
pomodoro                      100 gr        41     2.0     6.0     1.0
pompelmoes                      1 stuk      72     1.0    17.0     0.0
pompoen                       100 gr        36     1.0     8.0     0.0
poon (gekookt)                100 gr       113    17.0     0.0     5.0
popcorn                       100 gr       376    13.0    72.0     4.0
port salut                    100 gr       314    21.0     0.0    25.5
postelein (gekookt)           100 gr        16     2.0     2.0     0.0
postelijn                     100 gr        26     1.5     4.3     0.3
prei                          100 gr        28     2.0     5.0     0.0
prei- en hamsalade            100 gr       271     2.3     8.5    25.3
prince chocolade (lu)           1 stuk     108     1.4    15.7     4.4
prinsessenbonen               100 gr        32     3.0     5.0     0.0
pro 80%                       100 gr       359    80.0     7.5     1.0
proteine blast                  1 stuk     136    10.2    17.7     2.7
pruim                           1 stuk      24     0.0     6.0     0.0
pruimen op siroop             100 gr        68     0.0    17.0     0.0
pruimen (geweekt)             100 gr       122     1.3    29.3     0.0
Q                           Eenheid       Kcal   Eiwit   Koolh.   Vet
quorn                         100 gr        86    12.5     1.8     3.2
R                           Eenheid       Kcal   Eiwit   Koolh.   Vet
raap                          100 gr        16     0.1     4.0     0.0
rabarber                        1 stuk       8     0.0     2.0     0.0
rabarbermoes                  100 gr        72     1.0    17.0     0.0
raclette fonduekaas           100 gr       356    25.6     0.0    28.2
radijsjes                     100 gr        20     1.0     4.0     0.0
rambol                        100 gr       282    13.0     8.0    22.0
rauwe ham                     100 gr       305    20.0     0.0    25.0
rauwkost (bladgroente)        100 gr        13     1.2     2.1     0.0
ravioli                       100 gr       113     5.0    12.0     5.0
ree                           100 gr       118    21.4     0.0     3.6
reuzel                        100 gr       900     0.0     0.0   100.0
riblap                        100 gr       265    34.0     0.0    14.4
rice crispies                 100 gr       377     6.0    86.0     1.0
ricotta                       100 gr       196     9.5     3.5    16.0
rijst (basmati)               100 gr       347     7.0    78.5     0.5
rijst (zilvervlies)           100 gr       369     8.9    78.0     2.4
rijstevlaai                   100 gr       255     7.5    31.7    10.9
rijstpap (danone)             100 gr       137     3.2    23.2     3.5
rijsttaart                    100 gr       249     5.3    38.0     8.4
rijstwafel                      1 stuk      26     0.5     6.0     0.0
rivella light                 100 ml         4     0.0     1.0     0.0
rode bessen                   100 gr        24     1.0     5.0     0.0
rode biet                     100 gr        37     1.5     7.6     0.1
rode kool                     100 gr        28     2.0     5.0     0.0
rodekool met appeltjes        100 gr        50     1.1     9.1     1.0
roerbakmie (Soubry)           100 gr       367    14.0    71.0     3.0
roggebrood (donker)           100 gr       189     5.0    40.0     1.0
roggebrood (licht)            100 gr       197     7.0    40.0     1.0
rolmops                         1 stuk     125    10.0     1.0     9.0
rondo                         100 gr       435     5.5    61.1    18.8
rookvlees                     100 gr       152    22.9     0.6     6.5
rookworst                     100 gr       338    13.0     4.0    30.0
rookworst (light)             100 gr       248    16.0     1.0    20.0
roomijs                       100 gr       159     4.0    20.0     7.0
roomijs caramel               100 ml       121     1.5    12.0     7.5
roomijs pecan caramel         100 ml       104     1.5    11.0     6.0
roomijs stracciatella         100 ml       117     1.5    12.0     7.0
roomkaas (60+)                100 gr       422    20.0     0.0    38.0
roomsoes                      100 gr       248     4.2    33.0    11.0
roquefort                     100 gr       359    19.0     1.0    31.0
rosbief                       100 gr       115    22.0     0.0     3.0
rosti                         100 gr       144     1.9    22.8     5.1
roti (alleen koek)            100 gr       244     8.2    43.3     4.3
roti (kip)                    100 gr       168    12.1    20.9     4.0
rozebottelsiroop              100 gr       228     0.0    57.0     0.0
rozijnen                      100 gr       276     2.0    64.8     1.0
rozijnenbrood                 100 gr       255     7.0    50.0     3.0
rubens                        100 gr       327    24.1     0.0    25.6
rundbouillion                 100 ml         1     0.0     0.3     0.0
rundergehakt                  100 gr       197    20.0     0.0    13.0
runderlappen (vet)            100 gr       278    31.0     0.7    16.9
runderpoelet                  100 gr       195    30.8     0.5     7.8
runderrollade                 100 gr       167    28.3     0.8     5.7
rundertong                    100 gr       210    16.0     0.5    16.0
S                           Eenheid       Kcal   Eiwit   Koolh.   Vet
saint paulin                  100 gr       329    25.0     1.0    25.0
salami                        100 gr       414    18.0     0.0    38.0
salami (beleg)                100 gr       522    18.0     0.0    50.0
salami (zwan)                 100 gr       487    17.6     0.0    46.3
sambal oelek                  100 gr        20     3.0     2.0     0.0
sandwich                        1 stuk     159     5.0    28.0     3.0
sandwichspread                100 gr       228     2.0    14.5    18.0
santane cottage cheese        100 gr       105    11.0     4.0     5.0
santane smeerkaas ham         100 gr       190    14.5     8.3    11.0
santane smeerkaas natuur      100 gr       190    14.5     8.3    11.0
santane tilsit                100 gr       281    32.0     0.1    17.0
santen. kokosmelk             100 gr       346     4.0     6.0    34.0
sardines (blik)               100 gr       226    24.0     1.0    14.0
sate kip-met saus             100 gr       187    16.0     6.0    11.0
sate varkens-met saus         100 gr       226    15.1     6.8    15.4
satesaus                      100 gr       310     8.5    18.5    22.5
saucijs                       100 gr       308    22.2     0.9    24.0
saucijzebroodje               100 gr       446    11.0    33.0    30.0
saucisson                     100 gr       375    15.0     0.7    34.7
saus napoletana               100 gr       208     0.0    52.0     0.0
sausijsjes (varken)           100 gr       252    18.0     0.0    20.0
scampi                        100 gr        90    18.0     0.0     2.0
schapekaas                    100 gr       341    13.9     8.9    27.8
schapekaas (mager)            100 gr       318    18.4     7.1    24.1
schapentong                   100 gr       187    13.5     0.0    14.8
schapevlees                   100 gr       293    17.0     0.0    25.0
schar (gebakken)              100 gr       118    21.5     0.6     3.3
schaschliksaus                100 gr        99     0.7    24.0     0.1
schelvis                      100 gr        76    18.0     0.0     0.5
schelvislever                 100 gr       408     7.0     0.0    42.3
schnitzel (met kaas)          100 gr       324    18.0    18.0    20.0
schol                         100 gr        68    17.0     0.0     0.1
schorseneren                  100 gr        68     1.0    16.0     0.0
schouderham                   100 gr       194    16.0     1.0    14.0
schuimpje                     100 gr       380     0.0    95.0     0.0
seitan                        100 gr        90    19.6     3.0     0.0
selderijsalade                100 gr       334     1.0     6.0    34.0
selderstengel                 100 gr        21     1.2     3.6     0.2
sesamzaad                     100 gr       614    26.0     6.0    54.0
shoarma met broodje           100 gr       236    10.8    14.7    14.9
shoarmarol                    100 gr       176     7.0    18.6     8.2
shoarmavlees                  100 gr       293    17.0     0.0    25.0
sinaasappel                     1 stuk      48     1.0    11.0     0.0
sjalot                        100 gr        75     1.3    17.0     0.2
sla                           100 gr        10     0.5     2.0     0.0
slagroom (geklopt)            100 gr       349     2.0    12.7    32.3
slagroom (ongeklopt)          100 gr       344     2.2     3.0    35.9
slagroomsoesje                100 gr       309     4.4    13.5    26.4
slagroomtaart                 100 gr       332     5.5    30.0    20.0
slakken                       100 gr        81    16.0     2.0     1.0
slasaus 25%                   100 gr       279     0.7    11.0    25.8
slasaus 50%                   100 gr       478     1.0     6.0    50.0
slasaus. 05% olie of light    100 gr        93     0.1    12.0     5.0
slavink                       100 gr       298    21.1     0.0    23.8
smarties                      100 gr       483     4.6    70.5    20.3
smeerkaas 20+                 100 gr       185    18.0     8.0     9.0
smeerkaas 30+                 100 gr       219    20.0     1.0    15.0
smeerkaas 40+                 100 gr       251    19.0     1.0    19.0
smeerkaas (volvet)            100 gr       269    19.0     1.0    21.0
snickers                        1 stuk     301     6.0    31.0    17.0
snijbiet (gekookt)            100 gr        24     3.0     3.0     0.0
snijbonen                     100 gr        16     2.0     2.0     0.0
snoek                         100 gr        82    18.2     0.0     1.0
soep                          100 gr        29     1.0     4.0     1.0
soepgroenten                  100 gr        32     2.0     6.0     0.0
soepstengel                   100 gr       360    14.0    67.0     4.0
sojabonen                     100 gr       171    15.2    10.4     7.6
sojabrokjes                   100 gr       114    17.2    10.6     0.3
sojadessert choco (alpro)     100 gr        81     3.0    13.1     1.8
sojadessert vanille (alpro)   100 gr        81     3.0    13.1     1.8
sojamelk                      100 gr        42     3.6     1.0     2.6
sojasaus                      100 gr       120    12.0    18.0     0.0
sojascheuten                  100 gr        31     2.0     4.6     0.5
spaghetti                     100 gr       346    12.0    71.0     1.5
spaghetti (volkoren)          100 gr       332    13.5    64.0     2.5
sparerib                      100 gr       308    22.2     0.9    24.0
speculaas                     100 gr       493     5.2    73.0    20.0
spek (gezouten)               100 gr       522    10.6     0.0    53.3
spekkie                       100 gr       352     6.0    82.0     0.0
sperziebonen (gekookt)        100 gr        24     2.3     3.8     0.0
spinazie                      100 gr        24     3.0     3.0     0.0
spinazie a la creme           100 gr        68     3.0     5.0     4.0
spirelli                      100 gr       349    12.0    72.0     1.4
spitskool (rauw)              100 gr        37     3.0     4.0     1.0
sprits                        100 gr       539     5.5    58.7    31.4
sprot (gebakken)              100 gr       334    21.6     3.0    26.2
spruiten                      100 gr        53     4.0     7.0     1.0
stilton                       100 gr       464    26.0     0.0    40.0
stokbrood                     100 gr       259     8.1    52.0     2.1
strooiaroma                   100 gr         1     0.2     0.2     0.0
stroop                        100 gr       288     0.0    72.0     0.0
stroopwafel                     1 stuk     136     1.0    15.0     8.0
struisvogelsteak              100 gr       108    21.0     0.0     2.7
studentenhaver                100 gr       468     8.8    35.3    32.4
sucadelappen                  100 gr       248    33.0     0.0    13.0
suiker                        100 gr       400     0.0   100.0     0.0
suikerbrood                   100 gr       294     6.1    64.0     1.5
suikerklontje                 100 gr       400     0.0   100.0     0.0
suikermeloen                  100 gr        28     0.9     6.3     0.0
sultana                       100 gr       378     6.6    72.8     6.8
supreme cheese (quick)          1 stuk     687    37.7    46.1    39.2   
T                           Eenheid       Kcal   Eiwit   Koolh.   Vet
taai-taai                     100 gr       263     3.4    60.4     0.9
taartbodem (groot 22 cm)      100 gr       351     8.0    73.0     3.0
taco shells (Old el paso)     100 gr       478     7.8    60.8    22.8
tagliatelle                   100 gr       373    14.1    70.8     3.7
tahin                         100 gr       553    21.9     0.1    51.7
tahoe                         100 gr       112    11.6     1.0     6.9
taksi                         100 gr        51     0.9    11.8     0.1
tamari                        100 gr       102    15.0    10.0     0.3
tartaar                       100 gr       189    25.6     1.2     9.1
tarwebrood                    100 gr       250     9.5    45.1     3.5
tarwekiemen                   100 gr       287    27.0    20.0    11.0
taug‚                         100 gr        41     5.0     3.0     1.0
tempe                         100 gr       141    10.8     8.0     7.3
theeworst                     100 gr       539    10.0     1.0    55.0
tjaptjoi                      100 gr       113     8.6     3.3     7.3
toffee                        100 gr       445     2.0    71.0    17.0
tofu                          100 gr        67     8.0     2.0     3.0
tomate-groentesap             100 gr        20     1.0     4.0     0.0
tomaten                       100 gr        16     1.0     3.0     0.0
tomaten-(curry) ketchup       100 gr        92     0.9    22.2     0.0
tomatenpuree (elvea)          100 gr        96     3.9    20.4     0.4
tomatesap                     100 gr        18     1.0     3.5     0.0
tompouce                      100 gr       286     3.8    36.5    13.9
tong (varken)                 100 gr       227    15.1     0.5    18.3
tong (gebakken)               100 gr       194    22.0     2.0    10.9
tong (gekookt)                100 gr       105    23.0     1.0     1.0
tongfilets                    100 gr        72    18.0     0.0     0.0
tonijn in olie                100 gr       228    21.0     0.0    16.0
tonijn, eigen nat             100 gr       113    27.0     0.0     0.5
toostje                       100 gr       359    14.0    67.0     4.0
topping (opgeklopt)           100 gr       216     4.0    23.0    12.0
tosti                           1 stuk     232     9.0    22.0    12.0
tuinbonen (gekookt)           100 gr        36     5.0     4.0     0.0
tuinkers                      100 gr        40     4.2     4.1     0.7
tussendoorbiscuit (chocola)   100 gr       451    11.5    62.0    17.5
tussendoorbiscuit (fruit)     100 gr       394     8.5    71.0     8.5
tussendoorbiscuit (krenten)   100 gr       373     9.0    73.0     5.0
tuttifrutti (geweekt)         100 gr        98     1.0    23.5     0.0
tv-worstjes (zwan)            100 gr       178     9.0     4.0    14.0
tweedrank                     100 gr        40     0.2     9.9     0.0
twix                            1 stuk     277     3.0    37.0    13.0
U                           Eenheid       Kcal   Eiwit   Koolh.   Vet
ui                            100 gr        44     1.0    10.0     0.0
uiensoep (franse)             100 gr        62     3.0     8.0     2.0
uitjes (devos lemmens)        100 gr        11     0.8     2.0     0.0
uitsmijter ham (2 eieren)     100 gr       249    12.8    16.3    14.7
uitsmijter kaas (2 eieren)    100 gr       284    13.6    16.2    18.3
umer                          100 gr        65     6.5     3.0     3.0
V                           Eenheid       Kcal   Eiwit   Koolh.   Vet
vanilleijs                    100 gr       187     3.2    25.5     8.0
vanillepudding                100 gr       105     4.5    19.0     1.3
vanillevla (mager)            100 gr        67     3.5    13.0     0.1
vanillevla (vol)              100 gr        75     2.9    10.1     2.6
varkensfilet                  100 gr       178    31.3     0.0     5.8
varkenshaas                   100 gr       147    27.6     0.4     3.9
varkenskotelet                100 gr       336    15.4     0.0    30.5
varkenslap (mager)            100 gr       172    30.2     0.2     5.6
varkenslap (vet)              100 gr       305    22.0     0.7    23.9
varkensoester                 100 gr       147    27.6     0.4     3.9
varkensreuzel                 100 gr       898     0.1     0.0    99.7
varkensschnitsel              100 gr       156    21.0     0.0     8.0
varkensschouderlap            100 gr       272    27.6     0.0    18.0
varkensvlees (mager)          100 gr       161    20.0     0.0     9.0
vegetarische groenteschijf    100 gr       133     3.5    12.8     7.5
vegetarische hamburger        100 gr       159    17.5     9.8     5.5
vegetarische kebab            100 gr       150    18.5     7.7     5.0
vegetarische schnitzel        100 gr       272    15.5    14.4    17.0
veldsla                       100 gr        13     1.8     0.7     0.4
venkel                        100 gr        36     2.0     7.0     0.0
vetarme geraspte kaas         100 gr       280    29.5     0.1    18.0
viennetta                     100 ml       155     2.0    12.0    11.0
vietnamese loempia            100 gr       204     7.4    21.9     9.6
Vifit calcimel                100 ml        65     3.0    11.0     1.0
vijgen (gedroogd)             100 gr       228     4.0    53.0     0.0
vijgen (gedroogd)             100 gr       273     4.0    62.0     1.0
vijgen (vers)                 100 gr        63     0.9    13.0     0.8
vinaigrettesaus               100 gr       532     0.2     0.0    59.0
visburger                     100 gr       238    16.4    13.9    13.0
vissalade                     100 gr       276     7.0     6.9    24.5
visschnitzel                  100 gr       238    16.4    13.9    13.0
vissticks                     100 gr       167    12.0    14.0     7.0
vitabis                       100 gr       417     8.6    76.2     8.6
vitalinea sinaas -chocolade     1 reep     116     0.9    21.3     3.0
vitalinea pruimen               1 reep     108     1.1    20.7     2.4
vitalinea abrikozen             1 reep     102     1.4    18.0     2.6
vitalinea rode vruchten         1 reep      81     1.1    14.8     1.9  
vleessaus uit pakje           100 gr        76     1.7     7.2     4.5
volkoren biscuit              100 gr       451     9.0    68.0    16.0
volkorenbrood                 100 gr       211     8.4    40.5     1.8
vruchten op siroop            100 gr        76     0.4    18.7     0.0
vruchtenhagelslag             100 gr       393     0.1    98.2     0.0
vruchtenkoekje                100 gr       292     0.0    73.0     0.0
vruchtenlimonade              100 gr        39     0.0     9.8     0.0
vruchtensaus                  100 gr       160     0.0    40.0     0.0
vruchtentaart                 100 gr       264     3.7    36.3    11.6
vruchtenvlaai                 100 gr       231     3.6    37.4     7.5
vruchtesap                    100 gr        41     0.0    10.1     0.0
W                           Eenheid       Kcal   Eiwit   Koolh.   Vet
wafel (choco)                 100 gr       472     5.0    59.0    24.0
wafel (suiker)                100 gr       467     5.0    60.0    23.0
wafels                          1 stuk     177     3.0    21.0     9.0
walnoten                      100 gr       659    15.0     8.0    63.0
watergruwel                   100 gr        60     1.0    14.0     0.0
waterkers                     100 gr        21     1.6     2.9     0.3
watermeloen                   100 gr        36     1.0     8.0     0.0
weense worstjes (zwan)        100 gr       119    10.0     4.0     7.0
whey proteine                 100 gr       382    81.5    11.7     1.0
wienerschnitzel               100 gr       188    20.1     6.3     9.2
wijting                       100 gr        77    18.0     0.0     0.6
winegums                      100 gr       204     1.0    50.0     0.0
wit waterbrood                100 gr       259     8.1    52.0     2.1
witloof                       100 gr        12     1.0     2.0     0.0
witte bonen                   100 gr       334    21.0    58.0     2.0
witte bonen in tomatensaus    100 gr        75     5.2    12.7     0.4
witte kool                    100 gr        24     1.4     4.2     0.2
wittebrood (melk)             100 gr       270     9.7    51.3     2.9
wittekool (gekookt)           100 gr        11     0.9     1.8     0.0
wittekool (rauw)              100 gr        24     2.0     4.0     0.0
wokkels                       100 gr       473     3.0    68.0    21.0
worstebroodje                 100 gr       395    13.0    25.0    27.0
wortelen                      100 gr        32     1.0     7.0     0.0
Y                           Eenheid       Kcal   Eiwit   Koolh.   Vet
yoghurt bio nature            100 gr        68     3.8     5.5     3.4
yoghurt (danone)              100 gr       103     3.6    16.0     2.8
yoghurt (halfvol)             100 gr        50     4.3     4.7     1.5
yoghurt (light met fruit)     100 gr        43     4.0     6.0     0.4
yoghurt (mager met fruit)     100 gr        65     3.6    12.4     0.1
yoghurt (mager)               100 gr        42     4.0     5.0     0.7
yoghurt (mager)               100 gr        33     4.0     4.0     0.1
yoghurt (vol met fruit)       100 gr        93     4.0    14.2     2.3
yoghurt (vol)                 100 gr        56     3.4     3.5     3.2
yoghurtdrank                  100 gr        66     3.2    13.3     0.0
yogonaise                     100 gr       276     0.8    12.0     25.0
Z                           Eenheid       Kcal   Eiwit   Koolh.   Vet
zalm (gerookt)                100 gr       136    25.0     0.0    4.0 
zalm in blik (rode)           100 gr       215    19.0     0.0   15.5
zalm in blik (roze)           100 gr       160    23.0     0.0    7.5
zalmfilet                     100 gr       206    20.0     0.0   14.0
zemelen                       100 gr       218    14.0    27.0    6.0
zemelkoek                       1 stuk      52     1.4     9.1    1.1
zilveruien (zoetzuur)         100 gr        28     0.0     7.0    0.0
zonnebloempitten              100 gr       632    18.0    13.0   56.5
zout biscuitje                100 gr       502     7.0    51.0   30.0
zout koekje                   100 gr       611     7.0    40.0   47.0
zout stokje                   100 gr       370    12.0    67.0    6.0
zure room                     100 gr       203     2.7     3.2   20.0
zuring                        100 gr        25     2.6     2.6    0.5
zuurkool                      100 gr        24     2.0     4.0    0.0
zuurkoolstamppot              100 gr        52     1.9    10.9    0.1
zuurtje                       100 gr       380     0.0    95.0    0.0
zwarte bessen                 100 gr        40     2.0     8.0    0.0
zwitserse strooikaas          100 gr       128    32.0     0.0    0.0
 */
