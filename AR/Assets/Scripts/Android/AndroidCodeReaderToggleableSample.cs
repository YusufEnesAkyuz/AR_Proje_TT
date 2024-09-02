using TMPro;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using ZXing;
using TMPro;

public class AndroidCodeReaderToggleableSample : MonoBehaviour
{
    [SerializeField]
    private ARCameraManager cameraManager;
    [SerializeField]
    private string lastResult = "";

    [SerializeField]
    private TextMeshProUGUI debugResultText;

    public GameObject objectToShow;
    public GameObject UI;

    private Texture2D cameraImageTexture;
    private bool scanningEnabled = false;

    public bool OnScanned;

    public Dropdown dropdown;

    public GameObject resultPanel;
    public TextMeshProUGUI resultText;
    public TextMeshProUGUI buttonText;
    public TextMeshProUGUI onscanned;
    public TextMeshProUGUI SonucText;
    public TextMeshProUGUI ýnfobtnText;
    public TextMeshProUGUI ReaderState;


    public string readerStateTextStr;
    public string InfoText;
    public string InfotnText;
    public string startBtnText;
    public string onscannedText;
    public string sonucTextstr;
    public GameObject ImageBackround;
    public GameObject MainCanvas;
    public ForDropdown DropdownScr;
    public onLanguageScr Language;


    private void Awake()
    {
        OnScanned = false;
        Language = GameObject.FindAnyObjectByType<onLanguageScr>(); 
    }

    private void Start()
    {
        LanguageSec();
        buttonText.text = startBtnText;
        onscanned.text = onscannedText;
        SonucText.text = sonucTextstr;
        ýnfobtnText.text = InfotnText;
        MainCanvas.SetActive(false);
        ImageBackround.SetActive(true);
        resultPanel.SetActive(false);
        //dropdown.onValueChanged.AddListener(delegate {
        //    DropdownValueChanged(dropdown);
        //});
        
    }

    public void LanguageSec()
    {
        if (PlayerPrefs.GetInt("DropdownValue") == 0)
        {
            Debug.Log("Ýngilizce Seçildi");
            InfoText = Language.instance.InfoTextCifteMinareEnglish;
            InfotnText = Language.instance.InfoBtnTextEnglish;
            startBtnText = Language.instance.StartBtnTextEnhlish;
            sonucTextstr = Language.instance.ResultTextEnglish;
            readerStateTextStr = Language.instance.ReaderStateTextEnglish;
        }
        else if (PlayerPrefs.GetInt("DropdownValue") == 1)
        {
            Debug.Log("Tükçe Seçildi");
            InfoText = Language.instance.InfoTextCifteMinareTurkey;
            InfotnText = Language.instance.InfoBtnTextTurkey;
            startBtnText = Language.instance.StartBtnTextTurkey;
            sonucTextstr = Language.instance.ResultTextTurkey;
            readerStateTextStr = Language.instance.ReaderStateTextTurkey;
        }
        else if (PlayerPrefs.GetInt("DropdownValue") == 2)
        {
            Debug.Log("Fransýzca Seçildi");
            InfoText = Language.instance.InfoTextCifteMinareFrance;
            InfotnText = Language.instance.InfoBtnTextFrance;
            startBtnText = Language.instance.StartBtnTextFrance;
            sonucTextstr = Language.instance.ResultTextFrance;
            readerStateTextStr = Language.instance.ReaderStateTextFrance;
        }
        else if (PlayerPrefs.GetInt("DropdownValue") == 3)
        {
            Debug.Log("Azerbaycanca Seçildi");
            InfoText = Language.instance.InfoTextCifteMinareAzerbeyjan;
            InfotnText = Language.instance.InfoBtnTextAzerbeyjan;
            startBtnText = Language.instance.StartBtnTexttAzerbeyjan;
            sonucTextstr = Language.instance.ResultTexttAzerbeyjan;
            readerStateTextStr = Language.instance.ReaderStateTexttAzerbeyjan;
        }
        else if (PlayerPrefs.GetInt("DropdownValue") == 4)
        {
            Debug.Log("Almanca Seçildi");
            InfoText = Language.instance.InfoTextCifteMinareGermany;
            InfotnText = Language.instance.InfoBtnTextGermany;
            startBtnText = Language.instance.StartBtnTextGermany;
            sonucTextstr = Language.instance.ResultTextGermany;
            readerStateTextStr = Language.instance.ReaderStateTextGermany;
        }
        else if (PlayerPrefs.GetInt("DropdownValue") == 5)
        {
            Debug.Log("Bulgarca Seçildi");
            InfoText = Language.instance.InfoTextCifteBulgaria;
            InfotnText = Language.instance.InfoBtnTextBulgaria;
            startBtnText = Language.instance.StartBtnTextBulgaria;
            sonucTextstr = Language.instance.ResultTextBulgaria;
            readerStateTextStr = Language.instance.ReaderStateTextBulgaria;
        }
        else if (PlayerPrefs.GetInt("DropdownValue") == 6)
        {
            Debug.Log("Gürcüce Seçildi");
            InfoText = Language.instance.InfoTextCifteMinarGeorgia;
            InfotnText = Language.instance.InfoBtnTextGeorgia;
            startBtnText = Language.instance.StartBtnTextGeorgia;
            sonucTextstr = Language.instance.ResultTextGeorgia;
            readerStateTextStr = Language.instance.ReaderStateTextGeorgia;
        }
        else if (PlayerPrefs.GetInt("DropdownValue") == 7)
        {
            Debug.Log("Rusça Seçildi");
            InfoText = Language.instance.InfoTextCifteMinareRussia;
            InfotnText = Language.instance.InfoBtnTextRussia;
            startBtnText = Language.instance.StartBtnTextRussia;
            sonucTextstr = Language.instance.ResultTextRussia;
            readerStateTextStr = Language.instance.ReaderStateTextRussia;
        }
        else if (PlayerPrefs.GetInt("DropdownValue") == 8)
        {
            Debug.Log("Ukranyaca Seçildi");
            InfoText = Language.instance.InfoTextCifteMinareUkraine;
            InfotnText = Language.instance.InfoBtnTextUkraine;
            startBtnText = Language.instance.StartBtnTextUkraine;
            sonucTextstr = Language.instance.ResultTextUkraine;
            readerStateTextStr = Language.instance.ReaderStateTextUkraine;
        }
        else if (PlayerPrefs.GetInt("DropdownValue") == 9)
        {
            Debug.Log("Felemekçe Seçildi");
            InfoText = Language.instance.InfoTextCifteNetherlands;
            InfotnText = Language.instance.InfoBtnTextNetherlands;
            startBtnText = Language.instance.StartBtnTextNetherlands;
            sonucTextstr = Language.instance.ResultTextNetherlands;
            readerStateTextStr = Language.instance.ReaderStateTextNetherlands;
        }
        else if (PlayerPrefs.GetInt("DropdownValue") == 10)
        {
            Debug.Log("Farsça Seçildi");
            InfoText = Language.instance.InfoTextCifteMinarIranian;
            InfotnText = Language.instance.InfoBtnTextIranian;
            startBtnText = Language.instance.StartBtnTextIranian;
            sonucTextstr = Language.instance.ResultTextIranian;
            readerStateTextStr = Language.instance.ReaderStateTextIranian;
        }
    }

    private IBarcodeReader barcodeReader = new BarcodeReader
    {
        AutoRotate = false,
        Options = new ZXing.Common.DecodingOptions
        {
            TryHarder = false
        }
    };

    //public void DropdownValueChanged(Dropdown change)
    //{
    //    switch (change.value)
    //    {
    //        case 0:
                
    //            break;
    //        case 1:
                
    //            break;
    //        case 2:
                
    //            break;
    //        default:
    //            Debug.Log("Bilinmeyen seçenek");
    //            break;
    //    }
    //}

    private Result result;
    
    private void OnEnable()
    {
        cameraManager.frameReceived += OnCameraFrameReceived;
    }

    private void OnDisable()
    {
        cameraManager.frameReceived -= OnCameraFrameReceived;
    }

    private void OnCameraFrameReceived(ARCameraFrameEventArgs eventArgs)
    {
        if (!scanningEnabled)
        {
            return;
        }

        if (!cameraManager.TryAcquireLatestCpuImage(out XRCpuImage image))
        {
            return;
        }

        var conversionParams = new XRCpuImage.ConversionParams
        {
            
            inputRect = new RectInt(0, 0, image.width, image.height),

           
            outputDimensions = new Vector2Int(image.width / 2, image.height / 2),

           
            outputFormat = TextureFormat.RGBA32,

            
            transformation = XRCpuImage.Transformation.MirrorY
        };

        
        int size = image.GetConvertedDataSize(conversionParams);

       
        var buffer = new NativeArray<byte>(size, Allocator.Temp);

        
        image.Convert(conversionParams, buffer);

   
        image.Dispose();

     
        cameraImageTexture = new Texture2D(
            conversionParams.outputDimensions.x,
            conversionParams.outputDimensions.y,
            conversionParams.outputFormat,
            false);

        cameraImageTexture.LoadRawTextureData(buffer);
        cameraImageTexture.Apply();

        buffer.Dispose();

        result = barcodeReader.Decode(cameraImageTexture.GetPixels32(), cameraImageTexture.width, cameraImageTexture.height);

        

        if (result != null)
        {
            lastResult = result.Text + " " + result.BarcodeFormat;
            debugResultText.text = lastResult;
            if (result.Text == "CifteMinareliMedrese" && OnScanned == false)
            {
                Show3DObject(); 
                OnScanned = true;
                resultPanel.SetActive(true);
                resultText.text = InfoText;
                

            }
        }
    }

    public void OnTransitionScannerCam()
    {
        ImageBackround.SetActive(false);
        MainCanvas.SetActive(true);
    }

    public void ToggleScanning()
    {
        scanningEnabled = !scanningEnabled;
    }

    public string GetCurrentState()
    {
        return readerStateTextStr + "  - " + scanningEnabled;
    }

    void Show3DObject()
    {
        Debug.Log("Instantiating object at camera position");
        
        Vector3 cameraPosition = cameraManager.transform.position;
        Quaternion cameraRotation = cameraManager.transform.rotation;
        UI.SetActive(false);
        
        Vector3 instantiatePosition = cameraPosition + cameraManager.transform.forward * 0.5f;

        
        if (objectToShow != null)
        {
            Instantiate(objectToShow, instantiatePosition, cameraRotation);
            Debug.Log("Object instantiated successfully");
        }
        else
        {
            Debug.LogError("objectToShow is null. Please assign a prefab in the Inspector.");
        }
    }
    
}