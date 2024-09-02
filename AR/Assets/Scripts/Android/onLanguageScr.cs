using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onLanguageScr : MonoBehaviour
{
    
    public string InfoBtnTextEnglish;
    public string StartBtnTextEnhlish;
    public string ResultTextEnglish;
    public string ReaderStateTextEnglish;

    public string InfoBtnTextTurkey;
    public string StartBtnTextTurkey;
    public string ResultTextTurkey;
    public string ReaderStateTextTurkey;

    public string InfoBtnTextFrance;
    public string StartBtnTextFrance;
    public string ResultTextFrance;
    public string ReaderStateTextFrance;

    public string InfoBtnTextAzerbeyjan;
    public string StartBtnTexttAzerbeyjan;
    public string ResultTexttAzerbeyjan;
    public string ReaderStateTexttAzerbeyjan;

    public string InfoBtnTextGermany;
    public string StartBtnTextGermany;
    public string ResultTextGermany;
    public string ReaderStateTextGermany;

    public string InfoBtnTextBulgaria;
    public string StartBtnTextBulgaria;
    public string ResultTextBulgaria;
    public string ReaderStateTextBulgaria;

    public string InfoBtnTextGeorgia;
    public string StartBtnTextGeorgia;
    public string ResultTextGeorgia;
    public string ReaderStateTextGeorgia;

    public string InfoBtnTextRussia;
    public string StartBtnTextRussia;
    public string ResultTextRussia;
    public string ReaderStateTextRussia;

    public string InfoBtnTextUkraine;
    public string StartBtnTextUkraine;
    public string ResultTextUkraine;
    public string ReaderStateTextUkraine;

    public string InfoBtnTextNetherlands;
    public string StartBtnTextNetherlands;
    public string ResultTextNetherlands;
    public string ReaderStateTextNetherlands;

    public string InfoBtnTextIranian;
    public string StartBtnTextIranian;
    public string ResultTextIranian;
    public string ReaderStateTextIranian;

    public string InfoTextCifteMinareEnglish;
    public string InfoTextCifteMinareTurkey;
    public string InfoTextCifteMinareFrance;
    public string InfoTextCifteMinareAzerbeyjan;
    public string InfoTextCifteMinareGermany;
    public string InfoTextCifteBulgaria;
    public string InfoTextCifteMinarGeorgia;
    public string InfoTextCifteMinareRussia;
    public string InfoTextCifteMinareUkraine;
    public string InfoTextCifteNetherlands;
    public string InfoTextCifteMinarIranian;

    public onLanguageScr instance;

    private void Awake()
    {
        onCifteMinareliMedreseLanguageSec();
        TurkishLanguage();
        Englishlanguage();
        FranceLanguage();
        AzerbejanLanguage();
        GermanyLanguage();
        BulgariaLanguage();
        GeorgiaLanguage();
        RussiaLanguage();
        UkraineLanguage();
        NetherlandsLanguage();
        IranianLanguage();
        instance = this;
    }

    private void Start()
    {
        
    }

    public void TurkishLanguage()
    {

        InfoBtnTextTurkey = "Tarihi Eseri İnceleyin";
        StartBtnTextTurkey = "QrCodu Okut";
        ResultTextTurkey = "Sonuç";
        ReaderStateTextTurkey = "Tarama Durumu";
    }

    public void Englishlanguage()
    {
        InfoBtnTextEnglish = "examine the historical artifact";
        StartBtnTextEnhlish = "Scan QrCode";
        ResultTextEnglish = "Scan Status";
        ReaderStateTextEnglish = "Scan Status";
    }

    public void FranceLanguage()
    {
        InfoBtnTextFrance = "examiner l'artefact historique";
        StartBtnTextFrance = "Scanner le code QR";
        ResultTextFrance = "conclusion";
        ReaderStateTextFrance = "État de la numérisation";
    }

    public void AzerbejanLanguage()
    {
        InfoBtnTextAzerbeyjan = "Tarixi Artefaktı nəzərdən keçirin";
        StartBtnTexttAzerbeyjan= "QrCode skan edin";
        ResultTexttAzerbeyjan = "Nəticə";
        ReaderStateTexttAzerbeyjan = "Skan vəziyyəti";
    }

    public void GermanyLanguage()
    {
        InfoBtnTextGermany = "Untersuchen Sie das historische Artefakt";
        StartBtnTextGermany = "QRCode scannen"; 
        ResultTextGermany = "Abschluss";
        ReaderStateTextGermany = "Scanstatus";
    }

    public void BulgariaLanguage()
    {
        InfoBtnTextBulgaria = "Състояние на сканиране";
        StartBtnTextBulgaria = "Сканирайте QrCode";
        ResultTextBulgaria = "Заключение";
        ReaderStateTextBulgaria = "Състояние на сканиране";
    }

    public void GeorgiaLanguage()
    {
        InfoBtnTextGeorgia = "შეისწავლეთ ისტორიული არტეფაქტი";
        StartBtnTextGeorgia = "QrCode-ის სკანირება";
        ResultTextGeorgia = "დასკვნა";
        ReaderStateTextGeorgia = "სკანირების სტატუსი";
    }

    public void RussiaLanguage()
    {
        InfoBtnTextRussia = "Осмотрите исторический артефакт";
        StartBtnTextRussia = "Сканировать QR-код";
        ResultTextRussia = "Заключение";
        ReaderStateTextRussia = "Статус сканирования";
    }

    public void UkraineLanguage()
    {
        InfoBtnTextUkraine = "Огляньте історичний артефакт";
        StartBtnTextUkraine = "Сканувати QrCode";
        ResultTextUkraine = "Висновок";
        ReaderStateTextUkraine = "Статус сканування";
    }

    public void NetherlandsLanguage()
    {
        InfoBtnTextNetherlands = "Onderzoek het historische artefact";
        StartBtnTextNetherlands = "QRCode scannen";
        ResultTextNetherlands = "Conclusie";
        ReaderStateTextNetherlands = "Scanstatus";
    }

    public void IranianLanguage()
    {
        InfoBtnTextIranian = "آثار تاریخی را بررسی کنید";
        StartBtnTextIranian = "QrCode را اسکن کنید";
        ResultTextIranian = "نتیجه گیری";
        ReaderStateTextIranian = "وضعیت اسکن";
    }

    public void onCifteMinareliMedreseLanguageSec()
    {
        InfoTextCifteMinareEnglish = "Çifte Minareli Medrese (Twin Minaret Madrasa) is an important structure from the Anatolian Seljuk period, located in Erzurum, Turkey. It is believed to have been constructed during the reign of Sultan Gıyaseddin Keyhüsrev II in the 13th century. The madrasa is named after its two tall, slender minarets that flank the grand entrance.The architectural features include rich stonework, geometric decorations, vegetal motifs, and figurative designs. The madrasa is an open courtyard structure with four iwans and rooms surrounding the courtyard. Historically used as a school, the building now serves as a museum and is considered one of the finest examples of Anatolian Seljuk architecture.";
        InfoTextCifteMinareTurkey = "Çifte Minareli Medrese, Erzurum'da yer alan ve Anadolu Selçuklu dönemine ait önemli bir yapıdır. 13. yüzyılda Sultan II. Gıyaseddin Keyhüsrev döneminde inşa edildiği tahmin edilen bu medrese, taç kapısının iki yanındaki yüksek, ince minareleriyle dikkat çeker. Bu minareler, medreseye adını vermiştir.Mimari özellikleri arasında, zengin taş işçiliği, geometrik süslemeler, bitkisel motifler ve figüratif desenler bulunur. Medrese, açık avlulu, dört eyvanlı bir yapıdır ve avlunun etrafında odalar sıralanmıştır. Tarih boyunca medrese olarak kullanılan bu yapı, günümüzde müze olarak hizmet vermektedir ve Anadolu Selçuklu mimarisinin en güzel örneklerinden biri olarak kabul edilir.";
        InfoTextCifteMinareFrance = "Çifte Minareli Medrese (Madrasa aux deux minarets) est une structure importante de la période seldjoukide d'Anatolie, située à Erzurum, en Turquie. On pense qu'elle a été construite sous le règne du sultan Gıyaseddin Keyhüsrev II au 13ème siècle. La madrasa tire son nom de ses deux minarets élancés et hauts qui encadrent l'entrée principale.Les caractéristiques architecturales comprennent des travaux de pierre riches, des décorations géométriques, des motifs végétaux et des dessins figuratifs. La madrasa est une structure à cour ouverte avec quatre iwans et des pièces entourant la cour. Historiquement utilisée comme école, elle sert maintenant de musée et est considérée comme l'un des plus beaux exemples de l'architecture seldjoukide d'Anatolie.";
        InfoTextCifteMinareAzerbeyjan = "Çifte Minareli Medrese, Türkiyənin Ərzurum şəhərində yerləşən Anadolu Səlcuq dövrünə aid mühüm bir abidədir. 13-cü əsrdə Sultan II Qiyasəddin Keyhüsrəv dövründə tikildiyi güman edilir. Medrese adını, əsas girişin iki tərəfində yerləşən hündür və incə minarələrdən alır.\r\n\r\nMemarlıq xüsusiyyətləri arasında zəngin daş işçiliyi, həndəsi naxışlar, bitki motivləri və figurativ dizaynlar var. Medrese açıq həyətli, dörd eyvanlı bir quruluşdur və həyətdə otaqlar sıralanmışdır. Tarixən məktəb kimi istifadə olunan bu bina, indi muzey kimi xidmət edir və Anadolu Səlcuq memarlığının ən gözəl nümunələrindən biri hesab olunur.";
        InfoTextCifteMinareGermany = "Die Çifte Minareli Medrese (Madrasa mit den zwei Minaretten) ist ein bedeutendes Bauwerk aus der Zeit der anatolischen Seldschuken, das sich in Erzurum, Türkei, befindet. Es wird angenommen, dass sie im 13. Jahrhundert während der Herrschaft von Sultan Gıyaseddin Keyhüsrev II. erbaut wurde. Die Madrasa verdankt ihren Namen den beiden hohen, schlanken Minaretten, die den Haupteingang flankieren.\r\n\r\nDie architektonischen Merkmale umfassen reichhaltige Steinmetzarbeiten, geometrische Verzierungen, pflanzliche Motive und figurative Designs. Die Madrasa ist ein Bauwerk mit offenem Innenhof und vier Iwanen, umgeben von Räumen. Historisch gesehen wurde sie als Schule genutzt, dient heute jedoch als Museum und gilt als eines der schönsten Beispiele der anatolischen Seldschukenarchitektur.";
        InfoTextCifteBulgaria = "Çifte Minareli Medrese (Медресе с двойни минарета) е важно архитектурно съоръжение от времето на Анатолийските селджуци, разположено в Ерзурум, Турция. Смята се, че е построено през XIII век по време на управлението на султан Гийаседдин Кейхюсрев II. Медресето получава името си от двете високи и тънки минарета, които ограждат главния вход.Архитектурните особености включват богата каменна резба, геометрични орнаменти, растителни мотиви и фигуративни дизайни. Медресето представлява структура с открит двор, четири айвана и стаи, разположени около двора. Исторически е използвано като училище, но днес функционира като музей и се смята за един от най-добрите примери на архитектурата на Анатолийските селджуци.";
        InfoTextCifteMinarGeorgia = "Çifte Minareli Medrese (ორმინარიანი მედრესე) არის მნიშვნელოვანი ნაგებობა ანატოლიის სელჩუკთა პერიოდისა, რომელიც მდებარეობს თურქეთის ერზურუმში. ითვლება, რომ იგი აშენდა XIII საუკუნეში სულთან გიასედინ ქეიხუსრევ II-ის მმართველობის დროს. მედრესეს სახელი დაერქვა მთავარი შესასვლელის ორივე მხარეს განლაგებული ორი მაღალი და წვრილი მინარეთის მიხედვით.არქიტექტურული მახასიათებლები მოიცავს მდიდარ ქვის ნაკეთობებს, გეომეტრიულ ორნამენტებს, მცენარეულ მოტივებს და ფიგურატიულ დიზაინებს. მედრესე არის ღია ეზოს მქონე ნაგებობა, რომლის ირგვლივ განლაგებულია ოთხი აივანი და ოთახები. ისტორიულად ის გამოიყენებოდა სკოლად, მაგრამ დღეს ფუნქციონირებს როგორც მუზეუმი და ითვლება ანატოლიის სელჩუკთა არქიტექტურის ერთ-ერთ საუკეთესო ნიმუშად.";
        InfoTextCifteMinareRussia = "Çifte Minareli Medrese (Медресе с двойными минаретами) — это важное сооружение периода анатолийских сельджуков, расположенное в Эрзуруме, Турция. Предполагается, что оно было построено в XIII веке при султане Гиясэддине Кейхюсреве II. Медресе получило свое название благодаря двум высоким и тонким минаретам, которые обрамляют главный вход.Архитектурные особенности включают богатую каменную резьбу, геометрические узоры, растительные мотивы и фигурные орнаменты. Медресе представляет собой сооружение с открытым двором, окруженным четырьмя айванами и комнатами. Исторически использовалось как учебное заведение, но сегодня функционирует как музей и считается одним из лучших образцов архитектуры анатолийских сельджуков.";
        InfoTextCifteMinareUkraine = "Çifte Minareli Medrese (Медресе з двома мінаретами) — важлива споруда періоду анатолійських сельджуків, розташована в Ерзурумі, Туреччина. Вважається, що вона була збудована у XIII столітті під час правління султана Гійаседдіна Кейхюсрева II. Медресе отримало свою назву завдяки двом високим і струнким мінаретам, які обрамляють головний вхід.Архітектурні особливості включають багате кам'яне різьблення, геометричні візерунки, рослинні мотиви та фігуративні орнаменти. Медресе є спорудою з відкритим двором, оточеним чотирма айванами та кімнатами. Історично використовувалася як навчальний заклад, але сьогодні функціонує як музей і вважається одним із найкращих зразків архітектури анатолійських сельджуків.";
        InfoTextCifteNetherlands = "Çifte Minareli Medrese (Twee-Minaret Madrasa) is een belangrijk gebouw uit de Anatolische Seltsjoekperiode, gelegen in Erzurum, Turkije. Het wordt aangenomen dat het werd gebouwd in de 13e eeuw tijdens het bewind van Sultan Gıyaseddin Keyhüsrev II. De madrasa ontleent zijn naam aan de twee hoge, slanke minaretten die de hoofdtoegang flankeren.Architectonische kenmerken omvatten rijke steenbewerking, geometrische versieringen, plantaardige motieven en figuratieve ontwerpen. De madrasa is een open binnenplaatsstructuur met vier iwans en kamers rondom de binnenplaats. Historisch gezien werd het als school gebruikt, maar tegenwoordig functioneert het als museum en wordt het beschouwd als een van de mooiste voorbeelden van Anatolische Seltsjoekarchitectuur.";
        InfoTextCifteMinarIranian = "Çifte Minareli Medrese (مدرسه دو مناره) یک بنای مهم از دوره سلاجقه آناتولی است که در ارزروم، ترکیه واقع شده است. به نظر می‌رسد که این بنا در قرن سیزدهم و در دوران سلطنت سلطان غیاث‌الدین کیخسرو دوم ساخته شده است. نام مدرسته از دو مناره بلند و باریک که در کنار ورودی اصلی قرار دارند گرفته شده است.\r\n\r\nویژگی‌های معماری شامل کارهای سنگی غنی، تزیینات هندسی، موتیف‌های گیاهی و طراحی‌های تصویری است. این مدرسته یک ساختار با حیاط باز است که چهار ایوان و اتاق‌هایی اطراف حیاط دارد. به‌طور تاریخی، از آن به‌عنوان مدرسه استفاده می‌شد، اما امروزه به‌عنوان موزه فعالیت می‌کند و به‌عنوان یکی از بهترین نمونه‌های معماری سلاجقه آناتولی شناخته می‌شود.\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
    }
}
