using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticasApp
{
    internal class Archivos
    {

        //public string getFiles(List<IFormFile> files)
        //{
        //    List<File> certificate = new List<File>();
        //    try
        //    {
        //        if (files == null || files.Count == 0)
        //        {
        //            return "Uploaded file is empty or null.";
        //        }
        //        var directory = context.Certifications.Select(x => x.DirectoryOrigin).FirstOrDefault();

        //        var formato = context.TypeFormat.Select(x => x.FormatName).ToList();
        //        var sizef = context.SizeFiles.Select(x => x.Size).ToList();

        //        foreach (var file in files)
        //        {
        //            double size = file.Length;
        //            size = size / 1000000;
        //            size = Math.Round(size, 2);
        //            var cadena = Path.GetExtension(file.FileName).Substring(1);
        //            var result = formato.Contains(cadena);
        //            var sizefil = sizef.Contains((int)size);

        //            if (!sizefil)
        //            {
        //                return "demasiado grande el archivo";
        //            }


        //            if (!result)
        //            {
        //                return "no se acepta esta extesion";
        //            }

        //            var currentpath = Directory.GetCurrentDirectory() + directory + file.FileName;
        //            using (var stream = File.Create(currentpath))
        //            {
        //                file.CopyToAsync(stream);
        //            }
        //            var certi = new Certifications();

        //            certi.NameFile = Path.GetFileNameWithoutExtension(file.FileName);
        //            certi.FileExtension = Path.GetExtension(file.FileName).Substring(1);
        //            certi.FileSize = size;
        //            certi.FileLocation = currentpath;
        //            certi.FileFormat = Path.GetExtension(file.FileName).Substring(1);
        //            certi.DirectoryOrigin = directory;
        //            certi.Createdate = DateTime.Now;
        //            certificate.Add(certi);
        //        }
        //        context.Certifications.AddRange(certificate);
        //        context.SaveChanges();
        //        return "uploaded files";

        //    }
        //    catch (EntityException ec)
        //    {
        //        throw new Exception(ec.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

    }
}
