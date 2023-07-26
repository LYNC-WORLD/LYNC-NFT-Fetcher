# LYNC-NFT-Fetcher

### Integrate NFT Fetching SDK into Game Engine

NFT Fetcher is a tool that allows developers to easily integrate NFT (Non-Fungible Tokens) into game engines like Unity and Unreal. With just a few clicks, developers can fetch NFT from specific chains and contracts and integrate them into their game.

## Get Your API Key
Please get your API key before downloading the SDK from https://www.lync.world/form.html

## Installation
Download the LYNC - NFT Fetcher SDK from here. Import the SDK .unitypackage file to your project. or simply drag and drop .unitypackage file to your project.

![image](https://github.com/LYNC-WORLD/LYNC-NFT-Fetcher/assets/42548654/ef1d5f8b-278e-4b79-aa56-36d116655a05)

Once the NFT Fetcher SDK has finished importing into your Unity project, you can begin integrating it into your game. To do this, open the NFTFetcher scene provided by the LYNC NFT Fetcher SDK.

```
                      Path : Assets ->LYNC-NFT-Fetcher -> NFTFetcher Scene
```

<img width="623" alt="Screenshot 2023-07-26 at 1 39 16 AM" src="https://github.com/LYNC-WORLD/LYNC-NFT-Fetcher/assets/42548654/712d03d2-67ca-41df-b33d-24530d935bd9">

To choose the blockchain network, simply go to the ChooseChain drop-down menu and pick the network of your contract address 

![image](https://github.com/LYNC-WORLD/LYNC-NFT-Fetcher/assets/42548654/602a8ac0-48c4-4bc4-ba45-0cdd4d62c850)

Pass the Contract Address on the selected chain. It will start fetching all the NFTs of that contract address.

![image](https://github.com/LYNC-WORLD/LYNC-NFT-Fetcher/assets/42548654/a9542a16-653d-4217-bd8c-dcd8dfe32691)

If you want gamers to fetch their NFTs from the wallet address, mark "Show User NFTS" as True (Mark Tick).

![image](https://github.com/LYNC-WORLD/LYNC-NFT-Fetcher/assets/42548654/96b06428-d4e9-4b84-9bc8-8f81d7ea75c6)


For testing in Unity Editor, Pass Wallet Address and NFTs will start showing.
If you wish to see logs, enable Debug Logs as True (Mark Tick).


## Fetch gamers NFTs from their wallet Address

Integrate LYNC Metamask Wallet SDK https://github.com/LYNC-WORLD/Metamask-Unity-Wallet-SDK

Once done, when you build on WebGL, it will fetch the gamer's NFTs from the specific wallet.
