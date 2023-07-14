/*
 * Copyright 2018 beanit
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except
 * in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software distributed under the License
 * is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and limitations under
 * the License.
 */
package com.beanit.iec61850bean.internal.cli;

public class Action {

  private final String key;
  private final String description;

  public Action(String key, String description) {
    this.key = key;
    this.description = description;
  }

  public String getKey() {
    return key;
  }

  public String getDescription() {
    return description;
  }
}
