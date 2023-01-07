using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

ProcessAsync().GetAwaiter().GetResult();
Console.ReadKey();

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static async Task ProcessAsync() {
    string storageConnectionString = "DefaultEndpointsProtocol=https;AccountName=sampleblob33d4;AccountKey=vbpSD/1p7750J7TLixwt8/KrqBn8+528IYH3SEnYLa9ZcfQYAJTXqHTO0vxCcfcZM1cAYB7vT0SO+ASt6BoCrA==;EndpointSuffix=core.windows.net";
    BlobServiceClient blobServiceClient = new BlobServiceClient(storageConnectionString);

    string containerName = "wtblob";
    BlobContainerClient blobContainerClient = blobServiceClient.GetBlobContainerClient(containerName);
    // Console.WriteLine("A container named '" + containerName + "' has been created. " +
    // "\nTake a minute and verify in the portal." + 
    // "\nNext a file will be created and uploaded to the container.");

    string localPath = "./data";
    string fileName = "wt" + Guid.NewGuid().ToString() + "file.txt";
    string localFilePath = Path.Combine(localPath, fileName);
    await File.WriteAllTextAsync(localFilePath, "Hello World!!");

    BlobClient blobClient = blobContainerClient.GetBlobClient(fileName);
    Console.WriteLine("Uploading to Blob storage as blob: \n\t {0}\n", blobClient.Uri);

    using (FileStream downloadFileStream = File.OpenRead(localFilePath))
    {
        //await download.Content.CopyToAsync(downloadFileStream);
        await blobClient.UploadAsync(downloadFileStream);
        downloadFileStream.Close();
    }

    Console.WriteLine("\nThe file was uploaded. We'll verify by listing" + 
        " the blobs next.");
    
    await foreach (BlobItem blobItem in blobContainerClient.GetBlobsAsync()) {
        Console.WriteLine("\t" + blobItem.Name);
    }

    Console.WriteLine("\nYou can also verify by looking inside the " + 
        "container in the portal." +
        "\nNext the blob will be downloaded with an altered file name.");

    string downloadFilePath = localFilePath.Replace(".txt", "_DOWNLOADED.txt");
    Console.WriteLine("\nDownloading blob to\n\t{0}\n", downloadFilePath);

    BlobDownloadInfo blobDownloadInfo = await blobClient.DownloadAsync();

    // using (FileStream downloadFileStream = File.OpenWrite(downloadFilePath))
    // {
    //     await downloadFileStream.CopyToAsync(downloadFileStream);
    // }

    await blobContainerClient.DeleteAsync();
    Console.ReadKey();

}
