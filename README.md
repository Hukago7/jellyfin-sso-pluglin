# Jellyfin SSO Auth Plugin

## 📌 Description
Ce plugin permet l'authentification Single Sign-On (**SSO**) avec **OpenID Connect** dans Jellyfin.

## 🚀 Installation

### **1️⃣ Compilation du plugin**
Si tu veux compiler le plugin à partir du code source :

```sh
git clone https://github.com/tonrepo/jellyfin-sso-plugin.git
cd jellyfin-sso-plugin
dotnet build --configuration Release
```

Après la compilation, le fichier **`Jellyfin.Plugin.SSOAuth.dll`** sera généré dans `bin/Release/net6.0/`.

---
### **2️⃣ Installation sur Jellyfin**

1. **Copier le fichier compilé** dans le dossier des plugins Jellyfin :
   ```sh
   mkdir -p /config/plugins/SSOAuth
   cp bin/Release/net6.0/Jellyfin.Plugin.SSOAuth.dll /config/plugins/SSOAuth/
   ```

2. **Redémarrer Jellyfin** :
   ```sh
   systemctl restart jellyfin  # Pour Linux
   ```
   ou **Docker** :
   ```sh
   docker restart jellyfin
   ```

---
### **3️⃣ Configuration via le dashboard**
1. **Se connecter à Jellyfin** en administrateur.
2. **Aller dans `Tableau de bord > Plugins > SSO Auth`**.
3. **Modifier les paramètres du provider** (`URL`, `Client ID`, `Client Secret`).
4. **Enregistrer** et tester la connexion SSO.

---
## ⚙️ **Configuration avancée**
- **Auto-création des utilisateurs** si non existants.
- **Assignation des rôles via OpenID Connect** (`admin`, `user`).
- **Connexion automatique après validation SSO**.

---
## ❓ Support et améliorations
Si tu veux contribuer ou signaler un bug, ouvre une issue sur [GitHub](https://github.com/tonrepo/jellyfin-sso-plugin/issues).
