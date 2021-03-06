using System;
using System.Web.UI.WebControls;

namespace SiteServer.Utils.Enumerations
{
	public enum EFileSystemType
	{
		Htm,
		Html,
        SHtml,
        Asp,
        Aspx,
        Php,
        Jsp,
		Txt,
		Xml,
        Json,
		Js,
		Ascx,
		Css,
        Csv,
		Jpg,
		Jpeg,
		Gif,
		Png,
		Bmp,
		Swf,
        Flv,
		Doc,
        Docx,
        Xls,
        Xlsx,
        Ppt,
        Pptx,
        Pdf,
		Mdb,
		Rm,
        Rmb,
        Rmvb,
		Mp3,
		Wav,
		Mid,
		Midi,
		Avi,
		Mpg,
		MPeg,
		Asf,
		Asx,
		Wma,
        Wmv,
        Smi,
		Rar,
		Zip,
		Dll,
        Image,
        Video,
		Directory,
		Unknown
	}

	public class EFileSystemTypeUtils
	{
		public static string GetValue(EFileSystemType type)
		{
		    if (type == EFileSystemType.Htm)
			{
				return ".htm";
			}
		    if (type == EFileSystemType.Html)
		    {
		        return ".html";
		    }
		    if (type == EFileSystemType.SHtml)
		    {
		        return ".shtml";
		    }
		    if (type == EFileSystemType.Asp)
		    {
		        return ".asp";
		    }
		    if (type == EFileSystemType.Aspx)
		    {
		        return ".aspx";
		    }
		    if (type == EFileSystemType.Php)
		    {
		        return ".php";
		    }
		    if (type == EFileSystemType.Jsp)
		    {
		        return ".jsp";
		    }
		    if (type == EFileSystemType.Txt)
		    {
		        return ".txt";
		    }
		    if (type == EFileSystemType.Xml)
		    {
		        return ".xml";
		    }
		    if (type == EFileSystemType.Json)
		    {
		        return ".json";
		    }
		    if (type == EFileSystemType.Js)
		    {
		        return ".js";
		    }
		    if (type == EFileSystemType.Ascx)
		    {
		        return ".ascx";
		    }
		    if (type == EFileSystemType.Css)
		    {
		        return ".css";
		    }
		    if (type == EFileSystemType.Csv)
		    {
		        return ".csv";
		    }
            if (type == EFileSystemType.Jpg)
		    {
		        return ".jpg";
		    }
		    if (type == EFileSystemType.Jpeg)
		    {
		        return ".jpeg";
		    }
		    if (type == EFileSystemType.Gif)
		    {
		        return ".gif";
		    }
		    if (type == EFileSystemType.Png)
		    {
		        return ".png";
		    }
		    if (type == EFileSystemType.Bmp)
		    {
		        return ".bmp";
		    }
		    if (type == EFileSystemType.Swf)
		    {
		        return ".swf";
		    }
		    if (type == EFileSystemType.Flv)
		    {
		        return ".flv";
		    }
		    if (type == EFileSystemType.Doc)
		    {
		        return ".doc";
		    }
		    if (type == EFileSystemType.Docx)
		    {
		        return ".docx";
		    }
		    if (type == EFileSystemType.Xls)
		    {
		        return ".xls";
		    }
		    if (type == EFileSystemType.Xlsx)
		    {
		        return ".xlsx";
		    }
		    if (type == EFileSystemType.Ppt)
		    {
		        return ".ppt";
		    }
		    if (type == EFileSystemType.Pptx)
		    {
		        return ".pptx";
		    }
		    if (type == EFileSystemType.Pdf)
		    {
		        return ".pdf";
		    }
		    if (type == EFileSystemType.Mdb)
		    {
		        return ".mdb";
		    }
		    if (type == EFileSystemType.Rm)
		    {
		        return ".rm";
		    }
		    if (type == EFileSystemType.Rmb)
		    {
		        return ".rmb";
		    }
		    if (type == EFileSystemType.Rmvb)
		    {
		        return ".rmvb";
		    }
		    if (type == EFileSystemType.Mp3)
		    {
		        return ".mp3";
		    }
		    if (type == EFileSystemType.Wav)
		    {
		        return ".wav";
		    }
		    if (type == EFileSystemType.Mid)
		    {
		        return ".mid";
		    }
		    if (type == EFileSystemType.Midi)
		    {
		        return ".midi";
		    }
		    if (type == EFileSystemType.Avi)
		    {
		        return ".avi";
		    }
		    if (type == EFileSystemType.Mpg)
		    {
		        return ".mpg";
		    }
		    if (type == EFileSystemType.MPeg)
		    {
		        return ".mpeg";
		    }
		    if (type == EFileSystemType.Asf)
		    {
		        return ".asf";
		    }
		    if (type == EFileSystemType.Asx)
		    {
		        return ".asx";
		    }
		    if (type == EFileSystemType.Wma)
		    {
		        return ".wma";
		    }
		    if (type == EFileSystemType.Wmv)
		    {
		        return ".wmv";
		    }
		    if (type == EFileSystemType.Smi)
		    {
		        return ".smi";
		    }
		    if (type == EFileSystemType.Rar)
		    {
		        return ".rar";
		    }
		    if (type == EFileSystemType.Zip)
		    {
		        return ".zip";
		    }
		    if (type == EFileSystemType.Dll)
		    {
		        return ".dll";
		    }
		    if (type == EFileSystemType.Image)
		    {
		        return ".image";
		    }
		    if (type == EFileSystemType.Video)
		    {
		        return ".video";
		    }
		    if (type == EFileSystemType.Directory)
		    {
		        return string.Empty;
		    }
		    if (type == EFileSystemType.Unknown)
		    {
		        return ".unknown";
		    }
		    throw new Exception();
		}

		public static string GetText(EFileSystemType type)
		{
		    if (type == EFileSystemType.Htm)
			{
				return "HTML Document";
			}
		    if (type == EFileSystemType.Html)
		    {
		        return "HTML Document";
		    }
		    if (type == EFileSystemType.SHtml)
		    {
		        return "HTML Document";
		    }
		    if (type == EFileSystemType.Asp)
		    {
		        return "Active Server Page";
		    }
		    if (type == EFileSystemType.Aspx)
		    {
		        return "Web Form";
		    }
		    if (type == EFileSystemType.Php)
		    {
		        return "PHP Server Page";
		    }
		    if (type == EFileSystemType.Jsp)
		    {
		        return "Java Server Page";
		    }
		    if (type == EFileSystemType.Txt)
		    {
		        return "文本文档";
		    }
		    if (type == EFileSystemType.Xml)
		    {
		        return "Xml 文档";
		    }
		    if (type == EFileSystemType.Json)
		    {
		        return "Json 文档";
		    }
		    if (type == EFileSystemType.Js)
		    {
		        return "JScript Script File";
		    }
		    if (type == EFileSystemType.Ascx)
		    {
		        return "Web User Control";
		    }
		    if (type == EFileSystemType.Css)
		    {
		        return "Cascading Style Sheet Document";
		    }
		    if (type == EFileSystemType.Csv)
		    {
		        return "Excel 工作表";
		    }
            if (type == EFileSystemType.Jpg)
		    {
		        return "JPEG 图像";
		    }
		    if (type == EFileSystemType.Jpeg)
		    {
		        return "JPEG 图像";
		    }
		    if (type == EFileSystemType.Gif)
		    {
		        return "GIF 图像";
		    }
		    if (type == EFileSystemType.Png)
		    {
		        return "PNG 图像";
		    }
		    if (type == EFileSystemType.Bmp)
		    {
		        return "BMP 图像";
		    }
		    if (type == EFileSystemType.Swf)
		    {
		        return "SWF 文件";
		    }
		    if (type == EFileSystemType.Flv)
		    {
		        return "Flash 歌曲文件";
		    }
		    if (type == EFileSystemType.Doc || type == EFileSystemType.Docx)
		    {
		        return "Word 文档";
		    }
		    if (type == EFileSystemType.Xls || type == EFileSystemType.Xlsx)
		    {
		        return "Excel 工作表";
		    }
		    if (type == EFileSystemType.Ppt || type == EFileSystemType.Pptx)
		    {
		        return "PowerPoint 演示文稿";
		    }
		    if (type == EFileSystemType.Pdf)
		    {
		        return "PDF 文件";
		    }
		    if (type == EFileSystemType.Mdb)
		    {
		        return "Access 站点程序";
		    }
		    if (type == EFileSystemType.Rm)
		    {
		        return "RealPlay 格式声音";
		    }
		    if (type == EFileSystemType.Rmb)
		    {
		        return "RealPlay 格式声音";
		    }
		    if (type == EFileSystemType.Rmvb)
		    {
		        return "RealPlay 格式声音";
		    }
		    if (type == EFileSystemType.Mp3)
		    {
		        return "MP3 格式声音";
		    }
		    if (type == EFileSystemType.Wav)
		    {
		        return "波形声音";
		    }
		    if (type == EFileSystemType.Mid)
		    {
		        return "MIDI 序列";
		    }
		    if (type == EFileSystemType.Midi)
		    {
		        return "MIDI 序列";
		    }
		    if (type == EFileSystemType.Avi)
		    {
		        return "歌曲剪辑";
		    }
		    if (type == EFileSystemType.Mpg)
		    {
		        return "电影剪辑";
		    }
		    if (type == EFileSystemType.MPeg)
		    {
		        return "电影剪辑";
		    }
		    if (type == EFileSystemType.Asf)
		    {
		        return "Windows Media 音频/歌曲文件";
		    }
		    if (type == EFileSystemType.Asx)
		    {
		        return "Windows Media 音频/歌曲播放列表";
		    }
		    if (type == EFileSystemType.Wma)
		    {
		        return "Windows Media 音频文件";
		    }
		    if (type == EFileSystemType.Wmv)
		    {
		        return "Windows Media 视频文件";
		    }
		    if (type == EFileSystemType.Smi)
		    {
		        return "Smi 音频文件";
		    }
		    if (type == EFileSystemType.Rar)
		    {
		        return "RAR 压缩文件";
		    }
		    if (type == EFileSystemType.Zip)
		    {
		        return "ZIP 压缩文件";
		    }
		    if (type == EFileSystemType.Dll)
		    {
		        return "Application Extension";
		    }
		    if (type == EFileSystemType.Image)
		    {
		        return "图片文件";
		    }
		    if (type == EFileSystemType.Video)
		    {
		        return "视频文件";
		    }
		    if (type == EFileSystemType.Directory)
		    {
		        return "文件夹";
		    }
		    if (type == EFileSystemType.Unknown)
		    {
		        return string.Empty;
		    }
		    throw new Exception();
		}

		public static EFileSystemType GetEnumType(string typeStr)
		{
			var retVal = EFileSystemType.Unknown;

			if (Equals(EFileSystemType.Htm, typeStr))
			{
				retVal = EFileSystemType.Htm;
			}
			else if (Equals(EFileSystemType.Html, typeStr))
			{
				retVal = EFileSystemType.Html;
            }
            else if (Equals(EFileSystemType.SHtml, typeStr))
            {
                retVal = EFileSystemType.SHtml;
            }
            else if (Equals(EFileSystemType.Asp, typeStr))
            {
                retVal = EFileSystemType.Asp;
            }
            else if (Equals(EFileSystemType.Aspx, typeStr))
            {
                retVal = EFileSystemType.Aspx;
            }
            else if (Equals(EFileSystemType.Php, typeStr))
            {
                retVal = EFileSystemType.Php;
            }
            else if (Equals(EFileSystemType.Jsp, typeStr))
            {
                retVal = EFileSystemType.Jsp;
            }
			else if (Equals(EFileSystemType.Txt, typeStr))
			{
				retVal = EFileSystemType.Txt;
			}
			else if (Equals(EFileSystemType.Xml, typeStr))
			{
				retVal = EFileSystemType.Xml;
            }
            else if (Equals(EFileSystemType.Json, typeStr))
            {
                retVal = EFileSystemType.Json;
            }
			else if (Equals(EFileSystemType.Js, typeStr))
			{
				retVal = EFileSystemType.Js;
            }
			else if (Equals(EFileSystemType.Ascx, typeStr))
			{
				retVal = EFileSystemType.Ascx;
			}
			else if (Equals(EFileSystemType.Css, typeStr))
			{
				retVal = EFileSystemType.Css;
			}
			else if (Equals(EFileSystemType.Csv, typeStr))
			{
			    retVal = EFileSystemType.Csv;
			}
            else if (Equals(EFileSystemType.Jpg, typeStr))
			{
				retVal = EFileSystemType.Jpg;
			}
			else if (Equals(EFileSystemType.Jpeg, typeStr))
			{
				retVal = EFileSystemType.Jpeg;
			}
			else if (Equals(EFileSystemType.Gif, typeStr))
			{
				retVal = EFileSystemType.Gif;
			}
			else if (Equals(EFileSystemType.Png, typeStr))
			{
				retVal = EFileSystemType.Png;
			}
			else if (Equals(EFileSystemType.Bmp, typeStr))
			{
				retVal = EFileSystemType.Bmp;
			}
			else if (Equals(EFileSystemType.Swf, typeStr))
			{
				retVal = EFileSystemType.Swf;
            }
            else if (Equals(EFileSystemType.Flv, typeStr))
            {
                retVal = EFileSystemType.Flv;
            }
			else if (Equals(EFileSystemType.Doc, typeStr))
			{
				retVal = EFileSystemType.Doc;
			}
            else if (Equals(EFileSystemType.Docx, typeStr))
            {
                retVal = EFileSystemType.Docx;
            }
            else if (Equals(EFileSystemType.Xls, typeStr))
			{
				retVal = EFileSystemType.Xls;
			}
            else if (Equals(EFileSystemType.Xlsx, typeStr))
            {
                retVal = EFileSystemType.Xlsx;
            }
            else if (Equals(EFileSystemType.Ppt, typeStr))
			{
				retVal = EFileSystemType.Ppt;
            }
            else if (Equals(EFileSystemType.Pptx, typeStr))
            {
                retVal = EFileSystemType.Pptx;
            }
            else if (Equals(EFileSystemType.Pdf, typeStr))
            {
                retVal = EFileSystemType.Pdf;
            }
			else if (Equals(EFileSystemType.Mdb, typeStr))
			{
				retVal = EFileSystemType.Mdb;
			}
			else if (Equals(EFileSystemType.Rm, typeStr))
			{
				retVal = EFileSystemType.Rm;
            }
            else if (Equals(EFileSystemType.Rmb, typeStr))
            {
                retVal = EFileSystemType.Rmb;
            }
            else if (Equals(EFileSystemType.Rmvb, typeStr))
            {
                retVal = EFileSystemType.Rmvb;
            }
			else if (Equals(EFileSystemType.Mp3, typeStr))
			{
				retVal = EFileSystemType.Mp3;
			}
			else if (Equals(EFileSystemType.Wav, typeStr))
			{
				retVal = EFileSystemType.Wav;
			}
			else if (Equals(EFileSystemType.Mid, typeStr))
			{
				retVal = EFileSystemType.Mid;
			}
			else if (Equals(EFileSystemType.Midi, typeStr))
			{
				retVal = EFileSystemType.Midi;
			}
			else if (Equals(EFileSystemType.Avi, typeStr))
			{
				retVal = EFileSystemType.Avi;
			}
			else if (Equals(EFileSystemType.Mpg, typeStr))
			{
				retVal = EFileSystemType.Mpg;
			}
			else if (Equals(EFileSystemType.MPeg, typeStr))
			{
				retVal = EFileSystemType.MPeg;
			}
			else if (Equals(EFileSystemType.Asf, typeStr))
			{
				retVal = EFileSystemType.Asf;
			}
			else if (Equals(EFileSystemType.Asx, typeStr))
			{
				retVal = EFileSystemType.Asx;
			}
			else if (Equals(EFileSystemType.Wma, typeStr))
			{
				retVal = EFileSystemType.Wma;
            }
            else if (Equals(EFileSystemType.Wmv, typeStr))
            {
                retVal = EFileSystemType.Wmv;
            }
            else if (Equals(EFileSystemType.Smi, typeStr))
            {
                retVal = EFileSystemType.Smi;
            }
			else if (Equals(EFileSystemType.Rar, typeStr))
			{
				retVal = EFileSystemType.Rar;
			}
			else if (Equals(EFileSystemType.Zip, typeStr))
			{
				retVal = EFileSystemType.Zip;
			}
			else if (Equals(EFileSystemType.Dll, typeStr))
			{
				retVal = EFileSystemType.Dll;
            }
            else if (Equals(EFileSystemType.Image, typeStr))
            {
                retVal = EFileSystemType.Image;
            }
            else if (Equals(EFileSystemType.Video, typeStr))
            {
                retVal = EFileSystemType.Video;
            }
			else if (Equals(EFileSystemType.Directory, typeStr))
			{
				retVal = EFileSystemType.Directory;
			}

			return retVal;
		}

        public static ListItem GetListItem(EFileSystemType type, bool selected)
        {
            var item = new ListItem(GetValue(type), GetValue(type));
            if (selected)
            {
                item.Selected = true;
            }
            return item;
        }

        public static void AddWebPageListItems(ListControl listControl)
        {
            if (listControl != null)
            {
                listControl.Items.Add(GetListItem(EFileSystemType.Html, false));
                listControl.Items.Add(GetListItem(EFileSystemType.Htm, false));
                listControl.Items.Add(GetListItem(EFileSystemType.SHtml, false));
                listControl.Items.Add(GetListItem(EFileSystemType.Xml, false));
                listControl.Items.Add(GetListItem(EFileSystemType.Json, false));
            }
        }

        public static string GetResponseContentType(EFileSystemType type)
        {
            if (type == EFileSystemType.Htm)
            {
                return "text/html";
            }
            if (type == EFileSystemType.Html)
            {
                return "text/html";
            }
            if (type == EFileSystemType.SHtml)
            {
                return "text/html";
            }
            if (type == EFileSystemType.Asp)
            {
                return "text/html";
            }
            if (type == EFileSystemType.Aspx)
            {
                return "text/html";
            }
            if (type == EFileSystemType.Php)
            {
                return "text/html";
            }
            if (type == EFileSystemType.Jsp)
            {
                return "text/html";
            }
            if (type == EFileSystemType.Txt)
            {
                return "text/plain";
            }
            if (type == EFileSystemType.Xml)
            {
                return "text/plain";
            }
            if (type == EFileSystemType.Json)
            {
                return "text/plain";
            }
            if (type == EFileSystemType.Js)
            {
                return "application/x-javascript";
            }
            if (type == EFileSystemType.Ascx)
            {
                return "text/html";
            }
            if (type == EFileSystemType.Css)
            {
                return "text/css";
            }
            if (type == EFileSystemType.Csv)
            {
                return "application/vnd.ms-excel";
            }
            if (type == EFileSystemType.Jpg)
            {
                return "image/jpeg";
            }
            if (type == EFileSystemType.Jpeg)
            {
                return "image/jpeg";
            }
            if (type == EFileSystemType.Gif)
            {
                return "image/gif";
            }
            if (type == EFileSystemType.Png)
            {
                return "image/png";
            }
            if (type == EFileSystemType.Bmp)
            {
                return "image/bmp";
            }
            if (type == EFileSystemType.Swf)
            {
                return "application/x-shockwave-flash";
            }
            if (type == EFileSystemType.Flv)
            {
                return "application/x-shockwave-flash";
            }
            if (type == EFileSystemType.Doc || type == EFileSystemType.Docx)
            {
                return "application/msword";
            }
            if (type == EFileSystemType.Xls || type == EFileSystemType.Xlsx)
            {
                return "application/vnd.ms-excel";
            }
            if (type == EFileSystemType.Ppt || type == EFileSystemType.Pptx)
            {
                return "application/vnd.ms-powerpoint";
            }
            if (type == EFileSystemType.Pdf)
            {
                return "";
            }
            if (type == EFileSystemType.Mdb)
            {
                return "";
            }
            if (type == EFileSystemType.Rm)
            {
                return "audio/x-pn-realaudio";
            }
            if (type == EFileSystemType.Rmb)
            {
                return "audio/x-pn-realaudio";
            }
            if (type == EFileSystemType.Rmvb)
            {
                return "audio/x-pn-realaudio";
            }
            if (type == EFileSystemType.Mp3)
            {
                return "audio/mpeg";
            }
            if (type == EFileSystemType.Wav)
            {
                return "audio/x-wav";
            }
            if (type == EFileSystemType.Mid)
            {
                return "audio/midi";
            }
            if (type == EFileSystemType.Midi)
            {
                return "audio/midi";
            }
            if (type == EFileSystemType.Avi)
            {
                return "video/x-msvideo";
            }
            if (type == EFileSystemType.Mpg)
            {
                return "video/mpeg";
            }
            if (type == EFileSystemType.MPeg)
            {
                return "video/mpeg";
            }
            if (type == EFileSystemType.Asf)
            {
                return "";
            }
            if (type == EFileSystemType.Asx)
            {
                return "";
            }
            if (type == EFileSystemType.Wma)
            {
                return "";
            }
            if (type == EFileSystemType.Wmv)
            {
                return "";
            }
            if (type == EFileSystemType.Smi)
            {
                return "";
            }
            if (type == EFileSystemType.Rar)
            {
                return "application/zip";
            }
            if (type == EFileSystemType.Zip)
            {
                return "application/zip";
            }
            if (type == EFileSystemType.Dll)
            {
                return "application/octet-stream";
            }
            if (type == EFileSystemType.Image)
            {
                return "";
            }
            if (type == EFileSystemType.Video)
            {
                return "";
            }
            if (type == EFileSystemType.Directory)
            {
                return "";
            }
            if (type == EFileSystemType.Unknown)
            {
                return string.Empty;
            }
            throw new Exception();
        }

		public static bool Equals(EFileSystemType type, string typeStr)
		{
			if (string.IsNullOrEmpty(typeStr)) return false;
			if (string.Equals(GetValue(type).ToLower(), typeStr.ToLower()))
			{
				return true;
			}
			return false;
		}

        public static bool Equals(string typeStr, EFileSystemType type)
        {
            return Equals(type, typeStr);
        }

        public static bool IsTextEditable(EFileSystemType type)
        {
            return type == EFileSystemType.Ascx || type == EFileSystemType.Asp || type == EFileSystemType.Aspx || type == EFileSystemType.Css || type == EFileSystemType.Htm || type == EFileSystemType.Html || type == EFileSystemType.Js || type == EFileSystemType.Jsp || type == EFileSystemType.Php || type == EFileSystemType.SHtml || type == EFileSystemType.Txt || type == EFileSystemType.Xml || type == EFileSystemType.Json;
        }

        public static bool IsHtml(string fileExtName)
        {
            var retVal = false;
            if (!string.IsNullOrEmpty(fileExtName))
            {
                fileExtName = fileExtName.ToLower().Trim();
                if (!fileExtName.StartsWith("."))
                {
                    fileExtName = "." + fileExtName;
                }
                if (fileExtName == ".asp" || fileExtName == ".aspx" || fileExtName == ".htm" || fileExtName == ".html" || fileExtName == ".jsp" || fileExtName == ".php" || fileExtName == ".shtml")
                {
                    retVal = true;
                }
            }
            return retVal;
        }

        /// <summary>
        /// 判断是否是样式文件
        /// add by sessionliang at 20151223
        /// </summary>
        /// <param name="fileExtName"></param>
        /// <returns></returns>
        public static bool IsCss(string fileExtName)
        {
            if (string.IsNullOrEmpty(fileExtName)) return false;

            var retVal = false;
            fileExtName = fileExtName.ToLower().Trim();
            if (!fileExtName.StartsWith("."))
            {
                fileExtName = "." + fileExtName;
            }
            if (fileExtName == ".css")
            {
                retVal = true;
            }
            return retVal;
        }

        /// <summary>
        /// 判断是否是脚本文件
        /// add by sessionliang at 20151223
        /// </summary>
        /// <param name="fileExtName"></param>
        /// <returns></returns>
        public static bool IsJs(string fileExtName)
        {
            if (string.IsNullOrEmpty(fileExtName)) return false;

            var retVal = false;
            fileExtName = fileExtName.ToLower().Trim();
            if (!fileExtName.StartsWith("."))
            {
                fileExtName = "." + fileExtName;
            }
            if (fileExtName == ".js")
            {
                retVal = true;
            }
            return retVal;
        }

        public static bool IsImage(string fileExtName)
        {
            var retVal = false;
            if (!string.IsNullOrEmpty(fileExtName))
            {
                fileExtName = fileExtName.ToLower().Trim();
                if (!fileExtName.StartsWith("."))
                {
                    fileExtName = "." + fileExtName;
                }
                if (fileExtName == ".bmp" || fileExtName == ".gif" || fileExtName == ".jpg" || fileExtName == ".jpeg" || fileExtName == ".png" || fileExtName == ".pneg" || fileExtName == ".webp")
                {
                    retVal = true;
                }
            }
            return retVal;
        }

        public static bool IsZip(string typeStr)
        {
            return Equals(EFileSystemType.Zip, typeStr);
        }

        public static bool IsFlash(string fileExtName)
        {
            var retVal = false;
            if (!string.IsNullOrEmpty(fileExtName))
            {
                fileExtName = fileExtName.ToLower().Trim();
                if (!fileExtName.StartsWith("."))
                {
                    fileExtName = "." + fileExtName;
                }
                if (fileExtName == ".swf")
                {
                    retVal = true;
                }
            }
            return retVal;
        }

        public static bool IsPlayer(string fileExtName)
        {
            var retVal = false;
            if (!string.IsNullOrEmpty(fileExtName))
            {
                fileExtName = fileExtName.ToLower().Trim();
                if (!fileExtName.StartsWith("."))
                {
                    fileExtName = "." + fileExtName;
                }
                if (fileExtName == ".flv" || fileExtName == ".avi" || fileExtName == ".mpg" || fileExtName == ".mpeg" || fileExtName == ".smi" || fileExtName == ".mp3" || fileExtName == ".mid" || fileExtName == ".midi" || fileExtName == ".rm" || fileExtName == ".rmb" || fileExtName == ".rmvb" || fileExtName == ".wmv" || fileExtName == ".wma" || fileExtName == ".asf" || fileExtName == ".mov" || fileExtName == ".mp4")
                {
                    retVal = true;
                }
            }
            return retVal;
        }

        public static bool IsImageOrFlashOrPlayer(string fileExtName)
        {
            var retVal = false;
            if (!string.IsNullOrEmpty(fileExtName))
            {
                fileExtName = fileExtName.ToLower().Trim();
                if (!fileExtName.StartsWith("."))
                {
                    fileExtName = "." + fileExtName;
                }
                if (fileExtName == ".bmp" || fileExtName == ".gif" || fileExtName == ".jpeg" || fileExtName == ".jpg" || fileExtName == ".png" || fileExtName == ".pneg" || fileExtName == ".webp" || fileExtName == ".swf")
                {
                    retVal = true;
                }
                if (retVal == false) retVal = IsPlayer(fileExtName);
            }
            return retVal;
        }

        public static bool IsDownload(EFileSystemType type)
        {
            var download = false;
            if (IsTextEditable(type) || IsImageOrFlashOrPlayer(GetValue(type)))
            {
                download = true;
            }
            else if (type == EFileSystemType.Pdf || type == EFileSystemType.Doc || type == EFileSystemType.Docx || type == EFileSystemType.Ppt || type == EFileSystemType.Pptx || type == EFileSystemType.Xls || type == EFileSystemType.Xlsx || type == EFileSystemType.Mdb)
            {
                download = true;
            }
            return download;
        }
	}
}
