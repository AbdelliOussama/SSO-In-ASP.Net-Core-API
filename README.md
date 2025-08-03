# 🔐 ASP.NET Core SSO Authentication System

This project demonstrates a **Single Sign-On (SSO)** authentication system using **ASP.NET Core**. It includes:

- 🧭 **Authentication Server**: Handles user authentication and token issuance.
- 📦 **Resource Server**: Protects APIs and verifies tokens.
- 🌐 **ClientApp1**: An MVC application that consumes the authentication service.
- 🌐 **ClientApp2**: Another MVC application using the same SSO system.



---

## ⚙️ Technologies Used

- ASP.NET Core 8
- IdentityServer4 / OpenIddict / JwtBearer 
- OAuth 2.0 / OpenID Connect
- MVC Pattern
- Entity Framework Core (if using Identity DB)

---

## 📚 How SSO Works in This Project

1. A user tries to access a secured page in **ClientApp1** or **ClientApp2**.
2. The user is redirected to the **AuthServer** to log in.
3. Upon successful login, the **AuthServer** issues an **ID token** and an **access token**.
4. The client application uses the tokens to:
   - Authenticate the user.
   - Call protected APIs from **ResourceServer**.
5. The user remains logged in across **both client apps**, thanks to the shared AuthServer.

---

## 🧪 Features

- 🔐 Centralized login across multiple applications
- 🧾 Token-based authentication (JWT)
- ⚔️ API protection with access token validation
- 🚪 Single Logout support (optional)

git clone https://github.com/your-username/your-repo-name.git
cd your-repo-name
