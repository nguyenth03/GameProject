    private void OnCollisionEnter2D(){
        //Sent when an incoming collider makes contact with this object's collider (2D physics only).

    }

    private void OnCollisionExit2D(){
        //Sent when a collider on another object stops touching this object's collider (2D physics only).

    }


    private void OnCollisionStay2D(){
        //Sent each frame where a collider on another object is touching this object's collider (2D physics only).
        float rechargeRate = 10.0f;
        float batteryLevel;
        if (collision.gameObject.tag == "RechargePoint")
        {
            batteryLevel = Mathf.Min(batteryLevel + rechargeRate * Time.deltaTime, 100.0f);
        }
    }


//test

private bool state = false;

    private void OnCollisionEnter2D(){
        //Sent when an incoming collider makes contact with this object's collider (2D physics only).
        state = true;
        for(int i = 0; i < 300; i++){
            if(i % 2 == 0){
                TakeDamege(20);
            }
        }
    }



    

