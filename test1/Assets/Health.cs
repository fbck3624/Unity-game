using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Text;
public class Health : MonoBehaviour
{
    [SerializeField] private Transform skillword;
    public string[] sarray = new string[8];
    public int[] isGo = {0,0,0,0,0,0,0,0};
    public int maxHealth,maxEnemyHealth;
    public HealthSystem hs = new HealthSystem(400,400);
    public int currentHealth,currentEnemyHealth;
    public RectTransform HealthBar,Hurt,EHealthBar,EHurt;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = hs.Healthmax;
        currentHealth = maxHealth;
        maxEnemyHealth = hs.EHealthMax;
        currentEnemyHealth = maxEnemyHealth;
        
    }
    
    public void SkillCreate(){
        SkillSystem ss = new SkillSystem();
        string skill = ss.skill.ToString();
        for(int i = 0; i < 8; i++){
            sarray[i] = skill.Substring(i,1);
            swCreate(sarray[i],i+7);
        }
        
        
    }
    public void Skill(){
        
        hs.EDamage(150);
        currentEnemyHealth = hs.ehealth;
    }
    public void swCreate(string word,int wposition){
        Transform sw = Instantiate(skillword, new Vector2(wposition,-5), Quaternion.identity);
        SkillWord2 sword = sw.GetComponent<SkillWord2>();
        sword.Setup(word);
    }
    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
    public void getDamage(){
        hs.IDamage(20);
        currentHealth = hs.health;
    }
    public void takeDamage(){
        hs.EDamage(70);
        currentEnemyHealth = hs.ehealth;
    }
    public void Outputs(){
        string s = "";
        for(int i = 0;i < 8;i++){
            s += isGo[i].ToString();
        }
        //Debug.Log(s);
    }
    public void allreset(){
        for(int k = 0;k < 8;k++){
            sarray[k] = "";
            isGo[k] = 0;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(currentEnemyHealth == 0){
            SceneManager.LoadScene("SuccessK");
        }
        
        if(isGo[0] == 1){
            if(isGo[1] == 1){
                if(isGo[2] == 1){
                    if(isGo[3] == 1){
                        if(isGo[4] == 1){
                            if(isGo[5] == 1){
                                if(isGo[6] == 1){
                                    if(isGo[7] == 1){
                                        
                                        Fungus.Flowchart.BroadcastFungusMessage("GOGO");
                                        allreset();
                                        
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.A)){
            string kcode = KeyCode.A.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                    
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.B)){
            string kcode = KeyCode.B.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.C)){
            string kcode = KeyCode.C.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.D)){
            string kcode = KeyCode.D.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.E)){
            string kcode = KeyCode.E.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.F)){
            string kcode = KeyCode.F.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    };
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.G)){
            string kcode = KeyCode.G.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.H)){
            string kcode = KeyCode.H.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.I)){
            string kcode = KeyCode.I.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.J)){
            string kcode = KeyCode.J.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.K)){
            string kcode = KeyCode.K.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.L)){
            string kcode = KeyCode.L.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.M)){
            string kcode = KeyCode.M.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.N)){
            string kcode = KeyCode.N.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.O)){
            string kcode = KeyCode.O.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.P)){
            string kcode = KeyCode.P.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.Q)){
            string kcode = KeyCode.Q.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.R)){
            string kcode = KeyCode.R.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.S)){
            string kcode = KeyCode.S.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.T)){
            string kcode = KeyCode.T.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.U)){
            string kcode = KeyCode.U.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.V)){
            string kcode = KeyCode.V.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.W)){
            string kcode = KeyCode.W.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.X)){
            string kcode = KeyCode.X.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.Y)){
            string kcode = KeyCode.Y.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.Z)){
            string kcode = KeyCode.Z.ToString();
            for(int i =0;i < 8;i++){
                if(kcode == sarray[i]){
                    int number = i;
                    if(isGo[number] == 1){
                    }
                    else{
                        isGo[number] = 1;
                        Outputs();
                        break;
                    }
                }
            }
        }
        /*if (Input.GetKeyDown(KeyCode.E))

        {
            hs.AttackEvent();
            currentHealth = hs.health;
            StartCoroutine(ExampleCoroutine());
            currentEnemyHealth = hs.ehealth;

        }
        if (Input.GetKeyDown(KeyCode.H)){
            hs.IHeal(100);
            currentHealth = hs.health;
        }
        
        //將綠色血條同步到當前血量長度
        if(Input.GetKeyDown(KeyCode.P)){
            SkillCreate();
        }*/
        HealthBar.sizeDelta = new Vector2(currentHealth, HealthBar.sizeDelta.y);
        EHealthBar.sizeDelta = new Vector2(currentEnemyHealth, EHealthBar.sizeDelta.y);
        //呈現傷害量
        if (EHurt.sizeDelta.x > EHealthBar.sizeDelta.x)

        {

            //讓傷害量(紅色血條)逐漸追上當前血量

            EHurt.sizeDelta += new Vector2(-1, 0)*Time.deltaTime*10;

        }
        if (Hurt.sizeDelta.x < HealthBar.sizeDelta.x)

        {

            //讓傷害量(紅色血條)逐漸追上當前血量

            Hurt.sizeDelta += new Vector2(1, 0);

        }
        if (Hurt.sizeDelta.x > HealthBar.sizeDelta.x)

        {

            //讓傷害量(紅色血條)逐漸追上當前血量

            Hurt.sizeDelta += new Vector2(-1, 0)*Time.deltaTime*10;

        }
    }
}
