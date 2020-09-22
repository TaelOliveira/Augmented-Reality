using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public AudioClip appleBite;
    public GameObject apple;
    public GameObject appleHalf;
    public GameObject showAppleButton;
    public GameObject eatAppleButton;
    int counterApple = 0;

    public GameObject ladyBug;
    public AudioClip lazyBugClip;
    public GameObject lazyBugCanvas;

    public GameObject cow;
    public AudioClip cowClip;
    public GameObject cowCanvas;

    public GameObject dragon;
    public GameObject dragonCanvas;
    public AudioClip dragonClip;

    public GameObject elephant;
    public GameObject elephantButtonCanvas;
    public AudioClip elephantClip;

    public GameObject fox;
    public GameObject foxButtonCanvas;
    public AudioClip foxRunClip;

    public GameObject goat;
    public GameObject goatCanvas;
    public AudioClip goatClip;

    public GameObject hog;
    public GameObject hogCanvas;
    public AudioClip hogClip;

    public GameObject iguana;
    public GameObject iguanaCanvas;

    public GameObject jellyfish;
    public GameObject jellyfishCanvas;
    public AudioClip jellyfishClip;

    public GameObject lizard;
    public GameObject lizardCanvas;
    public AudioClip lizardClip;

    public GameObject mouse;
    public GameObject mouseCanvas;
    public AudioClip mouseClip;

    public GameObject narwhal;
    public GameObject narwhalCanvas;
    public AudioClip waterSplashClip;

    public GameObject orangutan;
    public GameObject orangutanCanvas;
    public AudioClip orangutanClip;

    public GameObject penguin;
    public GameObject penguinCanvas;
    public AudioClip penguinClip;

    public GameObject quail;
    public GameObject quailCanvas;
    public AudioClip quailClip;

    public GameObject seahorse;
    public GameObject seahorseCanvas;

    public GameObject toucan;
    public GameObject toucanCanvas;

    public GameObject urial;
    public GameObject urialCanvas;

    public GameObject vulture;
    public GameObject vultureCanvas;
    public AudioClip vultureClip;

    public GameObject whale;
    public GameObject whaleCanvas;
    public AudioClip whaleClip;

    public GameObject xObject;
    public GameObject xCanvas;

    public GameObject yak;
    public GameObject yakCanvas;
    public AudioClip yakClip;

    public GameObject zebra;
    public GameObject zebraCanvas;

    public void Update(){

        if(Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, 100)){

                if(hit.transform.name == "Apple"){
                    eatAppleButton.SetActive(true);
                }

                if(hit.transform.name == "Ladybug"){
                    lazyBugCanvas.SetActive(true);
                }

                if(hit.transform.name == "Cow"){
                    cowCanvas.SetActive(true);
                }

                if(hit.transform.name == "Dragon"){
                    dragonCanvas.SetActive(true);
                }

                if(hit.transform.name == "Elephant"){
                    elephantButtonCanvas.SetActive(true);
                }

                if(hit.transform.name == "Fox"){
                    foxButtonCanvas.SetActive(true);
                }

                if(hit.transform.name == "Goat"){
                    goatCanvas.SetActive(true);
                }

                if(hit.transform.name == "Hog"){
                    hogCanvas.SetActive(true);
                }

                if(hit.transform.name == "Iguana"){
                    iguanaCanvas.SetActive(true);
                }

                if(hit.transform.name == "Jellyfish"){
                    jellyfishCanvas.SetActive(true);
                }

                if(hit.transform.name == "Lizard"){
                    lizardCanvas.SetActive(true);
                }

                if(hit.transform.name == "Mouse"){
                    mouseCanvas.SetActive(true);
                }

                if(hit.transform.name == "Narwhal"){
                    narwhalCanvas.SetActive(true);
                }

                if(hit.transform.name == "Orangutan"){
                    orangutanCanvas.SetActive(true);
                }

                if(hit.transform.name == "Penguin"){
                    penguinCanvas.SetActive(true);
                }

                if(hit.transform.name == "Quail"){
                    quailCanvas.SetActive(true);
                }

                if(hit.transform.name == "Seahorse"){
                    seahorseCanvas.SetActive(true);
                }

                if(hit.transform.name == "Toucan"){
                    toucanCanvas.SetActive(true);
                }

                if(hit.transform.name == "Urial"){
                    urialCanvas.SetActive(true);
                }

                if(hit.transform.name == "Vulture"){
                    vultureCanvas.SetActive(true);
                }

                if(hit.transform.name == "Whale"){
                    whaleCanvas.SetActive(true);
                }

                if(hit.transform.name == "X"){
                    xCanvas.SetActive(true);
                }

                if(hit.transform.name == "Yak"){
                    yakCanvas.SetActive(true);
                }

                if(hit.transform.name == "Zebra"){
                    zebraCanvas.SetActive(true);
                }
            }
        }
    }

    public void eatApple(){

        counterApple++;

        Debug.Log(counterApple);

        if(counterApple == 1){
            apple.SetActive(false);
            appleHalf.SetActive(true);
            SoundManager.instance.PlaySingle(appleBite);
        }
        if(counterApple == 2){
            SoundManager.instance.PlaySingle(appleBite);
            eatAppleButton.SetActive(false);
            appleHalf.SetActive(false);
            showAppleButton.SetActive(true);
            counterApple = 0;
        }

    }

    public void showApple(){
        apple.SetActive(true);
        showAppleButton.SetActive(false);
    }

    public void lazyBugSound(){
        SoundManager.instance.PlaySingle(lazyBugClip);
    }

    public void cowSound(){
        SoundManager.instance.PlaySingle(cowClip);
    }

    public void dragonAnimation(int animState){

        dragon.GetComponent<Animator>().SetInteger("dragonState", animState);

        if(animState == 2 || animState == 3){
            SoundManager.instance.PlaySingle(dragonClip);
        }

    }

    public void elephantSound(){
        SoundManager.instance.PlaySingle(elephantClip);
    }

    public void foxAnimation(int animState){

        fox.GetComponent<Animator>().SetInteger("foxState", animState);

        if(animState == 3){
            SoundManager.instance.PlaySingle(foxRunClip);
        }

    }

    public void goatSound(){
        SoundManager.instance.PlaySingle(goatClip);
    }

    public void hogSound(){
        SoundManager.instance.PlaySingle(hogClip);
    }

    public void iguanaAnimation(int animState){

        iguana.GetComponent<Animator>().SetInteger("iguanaState", animState);

    }

    public void jellyfishSound(){
        SoundManager.instance.PlaySingle(jellyfishClip);
    }

    public void lizardAnimation(int animState){

        lizard.GetComponent<Animator>().SetInteger("lizardState", animState);

        if(animState == 1){
            SoundManager.instance.PlaySingle(lizardClip);
        }

    }

    public void mouseSound(){
        SoundManager.instance.PlaySingle(mouseClip);
    }

    public void narwhalAnimation(int animState){

        narwhal.GetComponent<Animator>().SetInteger("narwhalState", animState);

        if(animState == 4){
            SoundManager.instance.PlaySingle(waterSplashClip);
        }

    }

    public void orangutanSound(){
        SoundManager.instance.PlaySingle(orangutanClip);
    }

    public void penguinAnimation(int animState){

        penguin.GetComponent<Animator>().SetInteger("penguinState", animState);

        if(animState == 0 || animState == 2){
            SoundManager.instance.PlaySingle(penguinClip);
        }

    }

    public void quailSound(){
        SoundManager.instance.PlaySingle(quailClip);
    }

    public void seahorseAnimation(int animState){

        seahorse.GetComponent<Animator>().SetInteger("seahorseState", animState);

    }

    public void toucanAnimation(int animState){

        toucan.GetComponent<Animator>().SetInteger("toucanState", animState);

    }

    public void urialAnimation(int animState){

        urial.GetComponent<Animator>().SetInteger("urialState", animState);

    }

    public void vultureSound(){
        SoundManager.instance.PlaySingle(vultureClip);
    }

    public void whaleSound(){
        SoundManager.instance.PlaySingle(whaleClip);
    }

    public void xAnimation(int animState){

        xObject.GetComponent<Animator>().SetInteger("xState", animState);

    }

    public void yakSound(){
        SoundManager.instance.PlaySingle(yakClip);
    }

    public void zebraAnimation(int animState){

        zebra.GetComponent<Animator>().SetInteger("zebraState", animState);

    }



}