### **Azure Web Apps**
####  <span style="color: DeepPink;">Find Outbound IPS (Bash cmd)</span></u>
<p>
<span style="color: Turquoise ;">
az webapp show \ --resource-group <group_name> \
    --name <app_name> \ 
    --query outboundIpAddresses \
    --output tsv
    </span>
</p>

<p>
<span style="color: Turquoise ;">
az webapp show \
    --resource-group <group_name> \ 
    --name <app_name> \ 
    --query possibleOutboundIpAddresses \
    --output tsv
</span>
</p>

#### <span style="color: DeepPink;">Create resource group to hold the value</span>
<p>
<span style="color: Turquoise ;">
resourceGroup=$(az group list --query "[].{id:name}" -o tsv)
appName=az204app$RANDOM 
</span>
</p>

<span style="color: DeepPink;">Start the application/ Update & Redeploy</span>
<p>
<span style="color: Turquoise ;">
az webapp up -g $resourceGroup -n $appName --html
</span>
</p>

#### <span style="color: DeepPink;">Create To view application logs in portal console</span>
<p>
<span style="color: Turquoise ;">
az webapp log tail --name appname --resource-group myResourceGroup
</span>
</p>

#### <span style="color: DeepPink;">Upload a certificate</span>
<p>
<span style="color: Turquoise ;">
openssl pkcs12 -export -out myserver.pfx -inkey "private-key-file" -in "merged-certificate-file"
</span>
</p>

<p> "az group create --name az204-blob-rg --location <myLocation>"
</p>

<p>az storage account create --resource-group az204-blob-rg --name \
<myStorageAcct> --location <myLocation> \ 
--kind BlockBlobStorage --sku Premium_LRS</p>

<p>az group delete --name az204-blob-rg --no-wait 
</p>

<p>
az storage account management-policy create \
    --account-name <storage-account> \
    --policy @policy.json \
    --resource-group <resource-group>
    </p>
    
#### Misselenious
"<a href="<webappname>.azurewebsites.net/?x-ms-routing-name=self">Go back to production app</a>"</br>

#### To be checked
Statefull/Stateless</br>
granular</br>


