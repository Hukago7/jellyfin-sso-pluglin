# 🇫🇷 Jellyfin SSO Auth Plugin / 🇬🇧 Plugin d'authentification SSO Jellyfin

## 📌 🇫🇷 Description / 🇬🇧 Description
🇫🇷 Ce plugin permet l'authentification Single Sign-On (**SSO**) avec **OpenID Connect** dans Jellyfin.

🇬🇧 This plugin enables Single Sign-On (**SSO**) authentication with **OpenID Connect** in Jellyfin.

Développé par / Developed by [Hukago7](https://github.com/Hukago7).

## 🚀 🇫🇷 Installation via le Magasin de Plugins Jellyfin / 🇬🇧 Installation via Jellyfin Plugin Store

### **1️⃣ 🇫🇷 Ajouter le dépôt du plugin / 🇬🇧 Add the plugin repository**
1. 🇫🇷 **Ouvrez Jellyfin** et allez dans **Tableau de bord > Plugins > Dépôts**.
   🇬🇧 **Open Jellyfin** and go to **Dashboard > Plugins > Repositories**.
2. 🇫🇷 **Ajoutez un nouveau dépôt** avec l'URL suivante :
   🇬🇧 **Add a new repository** with the following URL:
   ```
   https://hukago7.github.io/jellyfin-sso-plugin/manifest.json
   ```
3. 🇫🇷 **Enregistrez et actualisez la liste des plugins**.
   🇬🇧 **Save and refresh the list of plugins**.

### **2️⃣ 🇫🇷 Installer le plugin / 🇬🇧 Install the plugin**
1. 🇫🇷 Allez dans **Tableau de bord > Plugins > Catalogue**.
   🇬🇧 Go to Dashboard > Plugins > Catalog.
2. 🇫🇷 Recherchez **SSO Auth Plugin**.
   🇬🇧 Search for SSO Auth Plugin.
3. 🇫🇷 Installez le plugin et redémarrez Jellyfin.
   🇬🇧 Install the plugin and restart Jellyfin.

---

## 🚀 🇫🇷 Installation manuelle / 🇬🇧 Manual installation
🇫🇷 Si vous souhaitez compiler et installer le plugin manuellement :
🇬🇧 If you want to compile and install the plugin manually:

### **1️⃣ 🇫🇷 Compilation du plugin / 🇬🇧 Compile the plugin**

```sh
git clone https://github.com/Hukago7/jellyfin-sso-plugin.git
cd jellyfin-sso-plugin
dotnet build --configuration Release
```

🇫🇷 Après la compilation, le fichier **`Jellyfin.Plugin.SSOAuth.dll`** sera généré dans `bin/Release/net6.0/`.
🇬🇧 After compilation, the file **`Jellyfin.Plugin.SSOAuth.dll`** will be generated in `bin/Release/net6.0/`.

---
### **2️⃣ 🇫🇷 Installation sur Jellyfin / 🇬🇧 Install on Jellyfin**

1. 🇫🇷 **Copiez le fichier compilé** dans le dossier des plugins Jellyfin :
   🇬🇧 **Copy the compiled file** into Jellyfin's plugin folder:
   ```sh
   mkdir -p /config/plugins/SSOAuth
   cp bin/Release/net6.0/Jellyfin.Plugin.SSOAuth.dll /config/plugins/SSOAuth/
   ```

2. 🇫🇷 **Redémarrez Jellyfin** :
   🇬🇧 **Restart Jellyfin**:
   ```sh
   systemctl restart jellyfin  # 🇫🇷 Pour Linux / 🇬🇧 For Linux
   ```
   🇫🇷 ou **Docker** :
   🇬🇧 or **Docker**:
   ```sh
   docker restart jellyfin
   ```

---
### **3️⃣ 🇫🇷 Configuration via le dashboard / 🇬🇧 Configure via dashboard**
1. 🇫🇷 **Connectez-vous à Jellyfin** en administrateur.
   🇬🇧 **Log in to Jellyfin as an administrator**.
2. 🇫🇷 **Allez dans `Tableau de bord > Plugins > SSO Auth`**.
   🇬🇧 **Go to `Dashboard > Plugins > SSO Auth`**.
3. 🇫🇷 **Modifiez les paramètres du provider** (`URL`, `Client ID`, `Client Secret`).
   🇬🇧 **Modify the provider settings** (`URL`, `Client ID`, `Client Secret`).
4. 🇫🇷 **Enregistrez** et testez la connexion SSO.
   🇬🇧 **Save and test the SSO connection**.

---
## ⚙️ 🇫🇷 **Configuration avancée** / 🇬🇧 **Advanced configuration**
- 🇫🇷 **Auto-création des utilisateurs** si non existants.
  🇬🇧 **Automatic user creation if they do not exist**.
- 🇫🇷 **Assignation des rôles via OpenID Connect** (`admin`, `user`).
  🇬🇧 **Role assignment via OpenID Connect** (`admin`, `user`).
- 🇫🇷 **Connexion automatique après validation SSO**.
  🇬🇧 **Automatic login after SSO validation**.

---
## ❓ 🇫🇷 **Support et améliorations** / 🇬🇧 **Support and improvements**
🇫🇷 Si vous souhaitez contribuer ou signaler un bug, ouvrez une issue sur [GitHub](https://github.com/Hukago7/jellyfin-sso-plugin/issues).
🇬🇧 If you want to contribute or report a bug, open an issue on [GitHub](https://github.com/Hukago7/jellyfin-sso-plugin/issues).
