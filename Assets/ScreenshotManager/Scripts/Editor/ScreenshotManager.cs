#if UNITY_EDITOR
using System.IO;
using UnityEditor;
using UnityEngine;

public class ScreenshotManager {
    
    private const string PATH = "./Screenshots/";
    private const string NAME = "Screenshot";
    private const string EXTENSION = "png";
    private const string SUFFIX = "_";
    private const string DATE_FORMAT = "yyyy-MM-dd_HH-mm-ss";

    
    [MenuItem("Screenshot/Normal Quality &p")]
    public static void TakeScreenshot() {    
        string path = GetFilePath();
        ScreenCapture.CaptureScreenshot(path, 1);
        Debug.Log($"ScreenshotManager: Screenshot saved to {path}");
    }

    [MenuItem("Screenshot/High Quality &#p")]
    public static void TakeScreenshotHQ() {
        string path = GetFilePath();
        ScreenCapture.CaptureScreenshot(path, 2);
        Debug.Log($"ScreenshotManager: Screenshot saved to {path}");
    }

    private static string GetFilePath() {
        if(!Directory.Exists(PATH)) {
            Directory.CreateDirectory(PATH);
            Debug.Log($"Created Directroy named {PATH}");
        }
        return $"{PATH}{NAME}{SUFFIX}{System.DateTime.Now.ToString(DATE_FORMAT)}.{EXTENSION}";
    }

 
}
#endif