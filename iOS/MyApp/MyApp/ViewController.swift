//
//  ViewController.swift
//  MyApp
//
//  Created by HANYU ZHAO on 2014-07-30.
//  Copyright (c) 2014 HANYU ZHAO. All rights reserved.
//

import UIKit

class ViewController: UIViewController {
                            
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view, typically from a nib.
        
        
        let myTableView:UITableView = UITableView(frame:CGRectZero, style:.Grouped);
        let myTextField = UITextField(frame: CGRect(x: 0,y: 0,width: 200,height: 40))
        myTextField.textColor = UIColor.darkGrayColor()
        myTextField.text = "Hello World"
        
        let color = UIColor(red: 0.5, green: 0.5, blue: 0.5, alpha: 0.4)
        
        
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }



}

